// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package runtime -- go2cs converted at 2020 October 08 03:22:54 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\rwmutex.go
using atomic = go.runtime.@internal.atomic_package;
using static go.builtin;
using System;

namespace go
{
    public static partial class runtime_package
    {
        // This is a copy of sync/rwmutex.go rewritten to work in the runtime.

        // A rwmutex is a reader/writer mutual exclusion lock.
        // The lock can be held by an arbitrary number of readers or a single writer.
        // This is a variant of sync.RWMutex, for the runtime package.
        // Like mutex, rwmutex blocks the calling M.
        // It does not interact with the goroutine scheduler.
        private partial struct rwmutex
        {
            public mutex rLock; // protects readers, readerPass, writer
            public muintptr readers; // list of pending readers
            public uint readerPass; // number of pending readers to skip readers list

            public mutex wLock; // serializes writers
            public muintptr writer; // pending writer waiting for completing readers

            public uint readerCount; // number of pending readers
            public uint readerWait; // number of departing readers
        }

        private static readonly long rwmutexMaxReaders = (long)1L << (int)(30L);

        // rlock locks rw for reading.


        // rlock locks rw for reading.
        private static void rlock(this ptr<rwmutex> _addr_rw)
        {
            ref rwmutex rw = ref _addr_rw.val;
 
            // The reader must not be allowed to lose its P or else other
            // things blocking on the lock may consume all of the Ps and
            // deadlock (issue #20903). Alternatively, we could drop the P
            // while sleeping.
            acquirem();
            if (int32(atomic.Xadd(_addr_rw.readerCount, 1L)) < 0L)
            { 
                // A writer is pending. Park on the reader queue.
                systemstack(() =>
                {
                    lockWithRank(_addr_rw.rLock, lockRankRwmutexR);
                    if (rw.readerPass > 0L)
                    { 
                        // Writer finished.
                        rw.readerPass -= 1L;
                        unlock(_addr_rw.rLock);

                    }
                    else
                    { 
                        // Queue this reader to be woken by
                        // the writer.
                        var m = getg().m;
                        m.schedlink = rw.readers;
                        rw.readers.set(m);
                        unlock(_addr_rw.rLock);
                        notesleep(_addr_m.park);
                        noteclear(_addr_m.park);

                    }

                });

            }

        }

        // runlock undoes a single rlock call on rw.
        private static void runlock(this ptr<rwmutex> _addr_rw)
        {
            ref rwmutex rw = ref _addr_rw.val;

            {
                var r = int32(atomic.Xadd(_addr_rw.readerCount, -1L));

                if (r < 0L)
                {
                    if (r + 1L == 0L || r + 1L == -rwmutexMaxReaders)
                    {
                        throw("runlock of unlocked rwmutex");
                    } 
                    // A writer is pending.
                    if (atomic.Xadd(_addr_rw.readerWait, -1L) == 0L)
                    { 
                        // The last reader unblocks the writer.
                        lockWithRank(_addr_rw.rLock, lockRankRwmutexR);
                        var w = rw.writer.ptr();
                        if (w != null)
                        {
                            notewakeup(_addr_w.park);
                        }

                        unlock(_addr_rw.rLock);

                    }

                }

            }

            releasem(getg().m);

        }

        // lock locks rw for writing.
        private static void @lock(this ptr<rwmutex> _addr_rw)
        {
            ref rwmutex rw = ref _addr_rw.val;
 
            // Resolve competition with other writers and stick to our P.
            lockWithRank(_addr_rw.wLock, lockRankRwmutexW);
            var m = getg().m; 
            // Announce that there is a pending writer.
            var r = int32(atomic.Xadd(_addr_rw.readerCount, -rwmutexMaxReaders)) + rwmutexMaxReaders; 
            // Wait for any active readers to complete.
            lockWithRank(_addr_rw.rLock, lockRankRwmutexR);
            if (r != 0L && atomic.Xadd(_addr_rw.readerWait, r) != 0L)
            { 
                // Wait for reader to wake us up.
                systemstack(() =>
                {
                    rw.writer.set(m);
                    unlock(_addr_rw.rLock);
                    notesleep(_addr_m.park);
                    noteclear(_addr_m.park);
                }
            else
);

            }            {
                unlock(_addr_rw.rLock);
            }

        }

        // unlock unlocks rw for writing.
        private static void unlock(this ptr<rwmutex> _addr_rw)
        {
            ref rwmutex rw = ref _addr_rw.val;
 
            // Announce to readers that there is no active writer.
            var r = int32(atomic.Xadd(_addr_rw.readerCount, rwmutexMaxReaders));
            if (r >= rwmutexMaxReaders)
            {
                throw("unlock of unlocked rwmutex");
            } 
            // Unblock blocked readers.
            lockWithRank(_addr_rw.rLock, lockRankRwmutexR);
            while (rw.readers.ptr() != null)
            {
                var reader = rw.readers.ptr();
                rw.readers = reader.schedlink;
                reader.schedlink.set(null);
                notewakeup(_addr_reader.park);
                r -= 1L;
            } 
            // If r > 0, there are pending readers that aren't on the
            // queue. Tell them to skip waiting.
 
            // If r > 0, there are pending readers that aren't on the
            // queue. Tell them to skip waiting.
            rw.readerPass += uint32(r);
            unlock(_addr_rw.rLock); 
            // Allow other writers to proceed.
            unlock(_addr_rw.wLock);

        }
    }
}
