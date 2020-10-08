// cgo -godefs -- -fsigned-char types_freebsd.go | go run mkpost.go
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build arm64,freebsd

// package unix -- go2cs converted at 2020 October 08 04:53:29 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\ztypes_freebsd_arm64.go

using static go.builtin;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        public static readonly ulong SizeofPtr = (ulong)0x8UL;
        public static readonly ulong SizeofShort = (ulong)0x2UL;
        public static readonly ulong SizeofInt = (ulong)0x4UL;
        public static readonly ulong SizeofLong = (ulong)0x8UL;
        public static readonly ulong SizeofLongLong = (ulong)0x8UL;


        private partial struct _C_short // : short
        {
        }
        private partial struct _C_int // : int
        {
        }
        private partial struct _C_long // : long
        {
        }
        private partial struct _C_long_long // : long
        {
        }
        public partial struct Timespec
        {
            public long Sec;
            public long Nsec;
        }

        public partial struct Timeval
        {
            public long Sec;
            public long Usec;
        }

        public partial struct Rusage
        {
            public Timeval Utime;
            public Timeval Stime;
            public long Maxrss;
            public long Ixrss;
            public long Idrss;
            public long Isrss;
            public long Minflt;
            public long Majflt;
            public long Nswap;
            public long Inblock;
            public long Oublock;
            public long Msgsnd;
            public long Msgrcv;
            public long Nsignals;
            public long Nvcsw;
            public long Nivcsw;
        }

        public partial struct Rlimit
        {
            public long Cur;
            public long Max;
        }

        private partial struct _Gid_t // : uint
        {
        }

        private static readonly ulong _statfsVersion = (ulong)0x20140518UL;
        private static readonly ulong _dirblksiz = (ulong)0x400UL;


        public partial struct Stat_t
        {
            public ulong Dev;
            public ulong Ino;
            public ulong Nlink;
            public ushort Mode;
            public short _0;
            public uint Uid;
            public uint Gid;
            public int _1;
            public ulong Rdev;
            public Timespec Atim;
            public Timespec Mtim;
            public Timespec Ctim;
            public Timespec Btim;
            public long Size;
            public long Blocks;
            public int Blksize;
            public uint Flags;
            public ulong Gen;
            public array<ulong> Spare;
        }

        private partial struct stat_freebsd11_t
        {
            public uint Dev;
            public uint Ino;
            public ushort Mode;
            public ushort Nlink;
            public uint Uid;
            public uint Gid;
            public uint Rdev;
            public Timespec Atim;
            public Timespec Mtim;
            public Timespec Ctim;
            public long Size;
            public long Blocks;
            public int Blksize;
            public uint Flags;
            public uint Gen;
            public int Lspare;
            public Timespec Btim;
        }

        public partial struct Statfs_t
        {
            public uint Version;
            public uint Type;
            public ulong Flags;
            public ulong Bsize;
            public ulong Iosize;
            public ulong Blocks;
            public ulong Bfree;
            public long Bavail;
            public ulong Files;
            public long Ffree;
            public ulong Syncwrites;
            public ulong Asyncwrites;
            public ulong Syncreads;
            public ulong Asyncreads;
            public array<ulong> Spare;
            public uint Namemax;
            public uint Owner;
            public Fsid Fsid;
            public array<sbyte> Charspare;
            public array<byte> Fstypename;
            public array<byte> Mntfromname;
            public array<byte> Mntonname;
        }

        private partial struct statfs_freebsd11_t
        {
            public uint Version;
            public uint Type;
            public ulong Flags;
            public ulong Bsize;
            public ulong Iosize;
            public ulong Blocks;
            public ulong Bfree;
            public long Bavail;
            public ulong Files;
            public long Ffree;
            public ulong Syncwrites;
            public ulong Asyncwrites;
            public ulong Syncreads;
            public ulong Asyncreads;
            public array<ulong> Spare;
            public uint Namemax;
            public uint Owner;
            public Fsid Fsid;
            public array<sbyte> Charspare;
            public array<byte> Fstypename;
            public array<byte> Mntfromname;
            public array<byte> Mntonname;
        }

        public partial struct Flock_t
        {
            public long Start;
            public long Len;
            public int Pid;
            public short Type;
            public short Whence;
            public int Sysid;
            public array<byte> _;
        }

        public partial struct Dirent
        {
            public ulong Fileno;
            public long Off;
            public ushort Reclen;
            public byte Type;
            public byte Pad0;
            public ushort Namlen;
            public ushort Pad1;
            public array<sbyte> Name;
        }

        private partial struct dirent_freebsd11
        {
            public uint Fileno;
            public ushort Reclen;
            public byte Type;
            public byte Namlen;
            public array<sbyte> Name;
        }

        public partial struct Fsid
        {
            public array<int> Val;
        }

        public static readonly ulong PathMax = (ulong)0x400UL;


        public static readonly ulong FADV_NORMAL = (ulong)0x0UL;
        public static readonly ulong FADV_RANDOM = (ulong)0x1UL;
        public static readonly ulong FADV_SEQUENTIAL = (ulong)0x2UL;
        public static readonly ulong FADV_WILLNEED = (ulong)0x3UL;
        public static readonly ulong FADV_DONTNEED = (ulong)0x4UL;
        public static readonly ulong FADV_NOREUSE = (ulong)0x5UL;


        public partial struct RawSockaddrInet4
        {
            public byte Len;
            public byte Family;
            public ushort Port;
            public array<byte> Addr; /* in_addr */
            public array<sbyte> Zero;
        }

        public partial struct RawSockaddrInet6
        {
            public byte Len;
            public byte Family;
            public ushort Port;
            public uint Flowinfo;
            public array<byte> Addr; /* in6_addr */
            public uint Scope_id;
        }

        public partial struct RawSockaddrUnix
        {
            public byte Len;
            public byte Family;
            public array<sbyte> Path;
        }

        public partial struct RawSockaddrDatalink
        {
            public byte Len;
            public byte Family;
            public ushort Index;
            public byte Type;
            public byte Nlen;
            public byte Alen;
            public byte Slen;
            public array<sbyte> Data;
        }

        public partial struct RawSockaddr
        {
            public byte Len;
            public byte Family;
            public array<sbyte> Data;
        }

        public partial struct RawSockaddrAny
        {
            public RawSockaddr Addr;
            public array<sbyte> Pad;
        }

        private partial struct _Socklen // : uint
        {
        }

        public partial struct Linger
        {
            public int Onoff;
            public int Linger;
        }

        public partial struct Iovec
        {
            public ptr<byte> Base;
            public ulong Len;
        }

        public partial struct IPMreq
        {
            public array<byte> Multiaddr; /* in_addr */
            public array<byte> Interface; /* in_addr */
        }

        public partial struct IPMreqn
        {
            public array<byte> Multiaddr; /* in_addr */
            public array<byte> Address; /* in_addr */
            public int Ifindex;
        }

        public partial struct IPv6Mreq
        {
            public array<byte> Multiaddr; /* in6_addr */
            public uint Interface;
        }

        public partial struct Msghdr
        {
            public ptr<byte> Name;
            public uint Namelen;
            public ptr<Iovec> Iov;
            public int Iovlen;
            public ptr<byte> Control;
            public uint Controllen;
            public int Flags;
        }

        public partial struct Cmsghdr
        {
            public uint Len;
            public int Level;
            public int Type;
        }

        public partial struct Inet6Pktinfo
        {
            public array<byte> Addr; /* in6_addr */
            public uint Ifindex;
        }

        public partial struct IPv6MTUInfo
        {
            public RawSockaddrInet6 Addr;
            public uint Mtu;
        }

        public partial struct ICMPv6Filter
        {
            public array<uint> Filt;
        }

        public static readonly ulong SizeofSockaddrInet4 = (ulong)0x10UL;
        public static readonly ulong SizeofSockaddrInet6 = (ulong)0x1cUL;
        public static readonly ulong SizeofSockaddrAny = (ulong)0x6cUL;
        public static readonly ulong SizeofSockaddrUnix = (ulong)0x6aUL;
        public static readonly ulong SizeofSockaddrDatalink = (ulong)0x36UL;
        public static readonly ulong SizeofLinger = (ulong)0x8UL;
        public static readonly ulong SizeofIPMreq = (ulong)0x8UL;
        public static readonly ulong SizeofIPMreqn = (ulong)0xcUL;
        public static readonly ulong SizeofIPv6Mreq = (ulong)0x14UL;
        public static readonly ulong SizeofMsghdr = (ulong)0x30UL;
        public static readonly ulong SizeofCmsghdr = (ulong)0xcUL;
        public static readonly ulong SizeofInet6Pktinfo = (ulong)0x14UL;
        public static readonly ulong SizeofIPv6MTUInfo = (ulong)0x20UL;
        public static readonly ulong SizeofICMPv6Filter = (ulong)0x20UL;


        public static readonly ulong PTRACE_ATTACH = (ulong)0xaUL;
        public static readonly ulong PTRACE_CONT = (ulong)0x7UL;
        public static readonly ulong PTRACE_DETACH = (ulong)0xbUL;
        public static readonly ulong PTRACE_GETFPREGS = (ulong)0x23UL;
        public static readonly ulong PTRACE_GETLWPLIST = (ulong)0xfUL;
        public static readonly ulong PTRACE_GETNUMLWPS = (ulong)0xeUL;
        public static readonly ulong PTRACE_GETREGS = (ulong)0x21UL;
        public static readonly ulong PTRACE_IO = (ulong)0xcUL;
        public static readonly ulong PTRACE_KILL = (ulong)0x8UL;
        public static readonly ulong PTRACE_LWPEVENTS = (ulong)0x18UL;
        public static readonly ulong PTRACE_LWPINFO = (ulong)0xdUL;
        public static readonly ulong PTRACE_SETFPREGS = (ulong)0x24UL;
        public static readonly ulong PTRACE_SETREGS = (ulong)0x22UL;
        public static readonly ulong PTRACE_SINGLESTEP = (ulong)0x9UL;
        public static readonly ulong PTRACE_TRACEME = (ulong)0x0UL;


        public static readonly ulong PIOD_READ_D = (ulong)0x1UL;
        public static readonly ulong PIOD_WRITE_D = (ulong)0x2UL;
        public static readonly ulong PIOD_READ_I = (ulong)0x3UL;
        public static readonly ulong PIOD_WRITE_I = (ulong)0x4UL;


        public static readonly ulong PL_FLAG_BORN = (ulong)0x100UL;
        public static readonly ulong PL_FLAG_EXITED = (ulong)0x200UL;
        public static readonly ulong PL_FLAG_SI = (ulong)0x20UL;


        public static readonly ulong TRAP_BRKPT = (ulong)0x1UL;
        public static readonly ulong TRAP_TRACE = (ulong)0x2UL;


        public partial struct PtraceLwpInfoStruct
        {
            public int Lwpid;
            public int Event;
            public int Flags;
            public Sigset_t Sigmask;
            public Sigset_t Siglist;
            public __Siginfo Siginfo;
            public array<sbyte> Tdname;
            public int Child_pid;
            public uint Syscall_code;
            public uint Syscall_narg;
        }

        private partial struct __Siginfo
        {
            public int Signo;
            public int Errno;
            public int Code;
            public int Pid;
            public uint Uid;
            public int Status;
            public ptr<byte> Addr;
            public array<byte> Value;
            public array<byte> _;
        }

        public partial struct Sigset_t
        {
            public array<uint> Val;
        }

        public partial struct Reg
        {
            public array<ulong> X;
            public ulong Lr;
            public ulong Sp;
            public ulong Elr;
            public uint Spsr;
            public array<byte> _;
        }

        public partial struct FpReg
        {
            public array<array<byte>> Q;
            public uint Sr;
            public uint Cr;
            public array<byte> _;
        }

        public partial struct PtraceIoDesc
        {
            public int Op;
            public ptr<byte> Offs;
            public ptr<byte> Addr;
            public ulong Len;
        }

        public partial struct Kevent_t
        {
            public ulong Ident;
            public short Filter;
            public ushort Flags;
            public uint Fflags;
            public long Data;
            public ptr<byte> Udata;
        }

        public partial struct FdSet
        {
            public array<ulong> Bits;
        }

        private static readonly ulong sizeofIfMsghdr = (ulong)0xa8UL;
        public static readonly ulong SizeofIfMsghdr = (ulong)0xa8UL;
        private static readonly ulong sizeofIfData = (ulong)0x98UL;
        public static readonly ulong SizeofIfData = (ulong)0x98UL;
        public static readonly ulong SizeofIfaMsghdr = (ulong)0x14UL;
        public static readonly ulong SizeofIfmaMsghdr = (ulong)0x10UL;
        public static readonly ulong SizeofIfAnnounceMsghdr = (ulong)0x18UL;
        public static readonly ulong SizeofRtMsghdr = (ulong)0x98UL;
        public static readonly ulong SizeofRtMetrics = (ulong)0x70UL;


        private partial struct ifMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public ushort _;
            public ifData Data;
        }

        public partial struct IfMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public IfData Data;
        }

        private partial struct ifData
        {
            public byte Type;
            public byte Physical;
            public byte Addrlen;
            public byte Hdrlen;
            public byte Link_state;
            public byte Vhid;
            public ushort Datalen;
            public uint Mtu;
            public uint Metric;
            public ulong Baudrate;
            public ulong Ipackets;
            public ulong Ierrors;
            public ulong Opackets;
            public ulong Oerrors;
            public ulong Collisions;
            public ulong Ibytes;
            public ulong Obytes;
            public ulong Imcasts;
            public ulong Omcasts;
            public ulong Iqdrops;
            public ulong Oqdrops;
            public ulong Noproto;
            public ulong Hwassist;
            public array<byte> _;
            public array<byte> _;
        }

        public partial struct IfData
        {
            public byte Type;
            public byte Physical;
            public byte Addrlen;
            public byte Hdrlen;
            public byte Link_state;
            public byte Spare_char1;
            public byte Spare_char2;
            public byte Datalen;
            public ulong Mtu;
            public ulong Metric;
            public ulong Baudrate;
            public ulong Ipackets;
            public ulong Ierrors;
            public ulong Opackets;
            public ulong Oerrors;
            public ulong Collisions;
            public ulong Ibytes;
            public ulong Obytes;
            public ulong Imcasts;
            public ulong Omcasts;
            public ulong Iqdrops;
            public ulong Noproto;
            public ulong Hwassist;
            public long Epoch;
            public Timeval Lastchange;
        }

        public partial struct IfaMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public ushort _;
            public int Metric;
        }

        public partial struct IfmaMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public ushort _;
        }

        public partial struct IfAnnounceMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public ushort Index;
            public array<sbyte> Name;
            public ushort What;
        }

        public partial struct RtMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public ushort Index;
            public ushort _;
            public int Flags;
            public int Addrs;
            public int Pid;
            public int Seq;
            public int Errno;
            public int Fmask;
            public ulong Inits;
            public RtMetrics Rmx;
        }

        public partial struct RtMetrics
        {
            public ulong Locks;
            public ulong Mtu;
            public ulong Hopcount;
            public ulong Expire;
            public ulong Recvpipe;
            public ulong Sendpipe;
            public ulong Ssthresh;
            public ulong Rtt;
            public ulong Rttvar;
            public ulong Pksent;
            public ulong Weight;
            public array<ulong> Filler;
        }

        public static readonly ulong SizeofBpfVersion = (ulong)0x4UL;
        public static readonly ulong SizeofBpfStat = (ulong)0x8UL;
        public static readonly ulong SizeofBpfZbuf = (ulong)0x18UL;
        public static readonly ulong SizeofBpfProgram = (ulong)0x10UL;
        public static readonly ulong SizeofBpfInsn = (ulong)0x8UL;
        public static readonly ulong SizeofBpfHdr = (ulong)0x20UL;
        public static readonly ulong SizeofBpfZbufHeader = (ulong)0x20UL;


        public partial struct BpfVersion
        {
            public ushort Major;
            public ushort Minor;
        }

        public partial struct BpfStat
        {
            public uint Recv;
            public uint Drop;
        }

        public partial struct BpfZbuf
        {
            public ptr<byte> Bufa;
            public ptr<byte> Bufb;
            public ulong Buflen;
        }

        public partial struct BpfProgram
        {
            public uint Len;
            public ptr<BpfInsn> Insns;
        }

        public partial struct BpfInsn
        {
            public ushort Code;
            public byte Jt;
            public byte Jf;
            public uint K;
        }

        public partial struct BpfHdr
        {
            public Timeval Tstamp;
            public uint Caplen;
            public uint Datalen;
            public ushort Hdrlen;
            public array<byte> _;
        }

        public partial struct BpfZbufHeader
        {
            public uint Kernel_gen;
            public uint Kernel_len;
            public uint User_gen;
            public array<uint> _;
        }

        public partial struct Termios
        {
            public uint Iflag;
            public uint Oflag;
            public uint Cflag;
            public uint Lflag;
            public array<byte> Cc;
            public uint Ispeed;
            public uint Ospeed;
        }

        public partial struct Winsize
        {
            public ushort Row;
            public ushort Col;
            public ushort Xpixel;
            public ushort Ypixel;
        }

        public static readonly ulong AT_FDCWD = (ulong)-0x64UL;
        public static readonly ulong AT_REMOVEDIR = (ulong)0x800UL;
        public static readonly ulong AT_SYMLINK_FOLLOW = (ulong)0x400UL;
        public static readonly ulong AT_SYMLINK_NOFOLLOW = (ulong)0x200UL;


        public partial struct PollFd
        {
            public int Fd;
            public short Events;
            public short Revents;
        }

        public static readonly ulong POLLERR = (ulong)0x8UL;
        public static readonly ulong POLLHUP = (ulong)0x10UL;
        public static readonly ulong POLLIN = (ulong)0x1UL;
        public static readonly ulong POLLINIGNEOF = (ulong)0x2000UL;
        public static readonly ulong POLLNVAL = (ulong)0x20UL;
        public static readonly ulong POLLOUT = (ulong)0x4UL;
        public static readonly ulong POLLPRI = (ulong)0x2UL;
        public static readonly ulong POLLRDBAND = (ulong)0x80UL;
        public static readonly ulong POLLRDNORM = (ulong)0x40UL;
        public static readonly ulong POLLWRBAND = (ulong)0x100UL;
        public static readonly ulong POLLWRNORM = (ulong)0x4UL;


        public partial struct CapRights
        {
            public array<ulong> Rights;
        }

        public partial struct Utsname
        {
            public array<byte> Sysname;
            public array<byte> Nodename;
            public array<byte> Release;
            public array<byte> Version;
            public array<byte> Machine;
        }

        public static readonly ulong SizeofClockinfo = (ulong)0x14UL;



        public partial struct Clockinfo
        {
            public int Hz;
            public int Tick;
            public int Spare;
            public int Stathz;
            public int Profhz;
        }
    }
}}}}}}
