// cgo -godefs types_netbsd.go | go run mkpost.go
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build 386,netbsd

// package unix -- go2cs converted at 2020 October 08 04:53:38 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\ztypes_netbsd_386.go

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
        public static readonly ulong SizeofPtr = (ulong)0x4UL;
        public static readonly ulong SizeofShort = (ulong)0x2UL;
        public static readonly ulong SizeofInt = (ulong)0x4UL;
        public static readonly ulong SizeofLong = (ulong)0x4UL;
        public static readonly ulong SizeofLongLong = (ulong)0x8UL;


        private partial struct _C_short // : short
        {
        }
        private partial struct _C_int // : int
        {
        }
        private partial struct _C_long // : int
        {
        }
        private partial struct _C_long_long // : long
        {
        }
        public partial struct Timespec
        {
            public long Sec;
            public int Nsec;
        }

        public partial struct Timeval
        {
            public long Sec;
            public int Usec;
        }

        public partial struct Rusage
        {
            public Timeval Utime;
            public Timeval Stime;
            public int Maxrss;
            public int Ixrss;
            public int Idrss;
            public int Isrss;
            public int Minflt;
            public int Majflt;
            public int Nswap;
            public int Inblock;
            public int Oublock;
            public int Msgsnd;
            public int Msgrcv;
            public int Nsignals;
            public int Nvcsw;
            public int Nivcsw;
        }

        public partial struct Rlimit
        {
            public ulong Cur;
            public ulong Max;
        }

        private partial struct _Gid_t // : uint
        {
        }

        public partial struct Stat_t
        {
            public ulong Dev;
            public uint Mode;
            public ulong Ino;
            public uint Nlink;
            public uint Uid;
            public uint Gid;
            public ulong Rdev;
            public Timespec Atim;
            public Timespec Mtim;
            public Timespec Ctim;
            public Timespec Btim;
            public long Size;
            public long Blocks;
            public uint Blksize;
            public uint Flags;
            public uint Gen;
            public array<uint> Spare;
        }

        public partial struct Statfs_t // : array<byte>
        {
        }

        public partial struct Statvfs_t
        {
            public uint Flag;
            public uint Bsize;
            public uint Frsize;
            public uint Iosize;
            public ulong Blocks;
            public ulong Bfree;
            public ulong Bavail;
            public ulong Bresvd;
            public ulong Files;
            public ulong Ffree;
            public ulong Favail;
            public ulong Fresvd;
            public ulong Syncreads;
            public ulong Syncwrites;
            public ulong Asyncreads;
            public ulong Asyncwrites;
            public Fsid Fsidx;
            public uint Fsid;
            public uint Namemax;
            public uint Owner;
            public array<uint> Spare;
            public array<byte> Fstypename;
            public array<byte> Mntonname;
            public array<byte> Mntfromname;
        }

        public partial struct Flock_t
        {
            public long Start;
            public long Len;
            public int Pid;
            public short Type;
            public short Whence;
        }

        public partial struct Dirent
        {
            public ulong Fileno;
            public ushort Reclen;
            public ushort Namlen;
            public byte Type;
            public array<sbyte> Name;
            public array<byte> Pad_cgo_0;
        }

        public partial struct Fsid
        {
            public array<int> X__fsid_val;
        }

        public static readonly ulong PathMax = (ulong)0x400UL;


        public static readonly ulong ST_WAIT = (ulong)0x1UL;
        public static readonly ulong ST_NOWAIT = (ulong)0x2UL;


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
            public uint Len;
        }

        public partial struct IPMreq
        {
            public array<byte> Multiaddr; /* in_addr */
            public array<byte> Interface; /* in_addr */
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
        public static readonly ulong SizeofSockaddrDatalink = (ulong)0x14UL;
        public static readonly ulong SizeofLinger = (ulong)0x8UL;
        public static readonly ulong SizeofIPMreq = (ulong)0x8UL;
        public static readonly ulong SizeofIPv6Mreq = (ulong)0x14UL;
        public static readonly ulong SizeofMsghdr = (ulong)0x1cUL;
        public static readonly ulong SizeofCmsghdr = (ulong)0xcUL;
        public static readonly ulong SizeofInet6Pktinfo = (ulong)0x14UL;
        public static readonly ulong SizeofIPv6MTUInfo = (ulong)0x20UL;
        public static readonly ulong SizeofICMPv6Filter = (ulong)0x20UL;


        public static readonly ulong PTRACE_TRACEME = (ulong)0x0UL;
        public static readonly ulong PTRACE_CONT = (ulong)0x7UL;
        public static readonly ulong PTRACE_KILL = (ulong)0x8UL;


        public partial struct Kevent_t
        {
            public uint Ident;
            public uint Filter;
            public uint Flags;
            public uint Fflags;
            public long Data;
            public int Udata;
        }

        public partial struct FdSet
        {
            public array<uint> Bits;
        }

        public static readonly ulong SizeofIfMsghdr = (ulong)0x98UL;
        public static readonly ulong SizeofIfData = (ulong)0x84UL;
        public static readonly ulong SizeofIfaMsghdr = (ulong)0x18UL;
        public static readonly ulong SizeofIfAnnounceMsghdr = (ulong)0x18UL;
        public static readonly ulong SizeofRtMsghdr = (ulong)0x78UL;
        public static readonly ulong SizeofRtMetrics = (ulong)0x50UL;


        public partial struct IfMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public array<byte> Pad_cgo_0;
            public IfData Data;
            public array<byte> Pad_cgo_1;
        }

        public partial struct IfData
        {
            public byte Type;
            public byte Addrlen;
            public byte Hdrlen;
            public array<byte> Pad_cgo_0;
            public int Link_state;
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
            public Timespec Lastchange;
        }

        public partial struct IfaMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public int Metric;
            public ushort Index;
            public array<byte> Pad_cgo_0;
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
            public array<byte> Pad_cgo_0;
            public int Flags;
            public int Addrs;
            public int Pid;
            public int Seq;
            public int Errno;
            public int Use;
            public int Inits;
            public array<byte> Pad_cgo_1;
            public RtMetrics Rmx;
        }

        public partial struct RtMetrics
        {
            public ulong Locks;
            public ulong Mtu;
            public ulong Hopcount;
            public ulong Recvpipe;
            public ulong Sendpipe;
            public ulong Ssthresh;
            public ulong Rtt;
            public ulong Rttvar;
            public long Expire;
            public long Pksent;
        }

        public partial struct Mclpool // : array<byte>
        {
        }

        public static readonly ulong SizeofBpfVersion = (ulong)0x4UL;
        public static readonly ulong SizeofBpfStat = (ulong)0x80UL;
        public static readonly ulong SizeofBpfProgram = (ulong)0x8UL;
        public static readonly ulong SizeofBpfInsn = (ulong)0x8UL;
        public static readonly ulong SizeofBpfHdr = (ulong)0x14UL;


        public partial struct BpfVersion
        {
            public ushort Major;
            public ushort Minor;
        }

        public partial struct BpfStat
        {
            public ulong Recv;
            public ulong Drop;
            public ulong Capt;
            public array<ulong> Padding;
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
            public BpfTimeval Tstamp;
            public uint Caplen;
            public uint Datalen;
            public ushort Hdrlen;
            public array<byte> Pad_cgo_0;
        }

        public partial struct BpfTimeval
        {
            public int Sec;
            public int Usec;
        }

        public partial struct Termios
        {
            public uint Iflag;
            public uint Oflag;
            public uint Cflag;
            public uint Lflag;
            public array<byte> Cc;
            public int Ispeed;
            public int Ospeed;
        }

        public partial struct Winsize
        {
            public ushort Row;
            public ushort Col;
            public ushort Xpixel;
            public ushort Ypixel;
        }

        public partial struct Ptmget
        {
            public int Cfd;
            public int Sfd;
            public array<byte> Cn;
            public array<byte> Sn;
        }

        public static readonly ulong AT_FDCWD = (ulong)-0x64UL;
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
        public static readonly ulong POLLNVAL = (ulong)0x20UL;
        public static readonly ulong POLLOUT = (ulong)0x4UL;
        public static readonly ulong POLLPRI = (ulong)0x2UL;
        public static readonly ulong POLLRDBAND = (ulong)0x80UL;
        public static readonly ulong POLLRDNORM = (ulong)0x40UL;
        public static readonly ulong POLLWRBAND = (ulong)0x100UL;
        public static readonly ulong POLLWRNORM = (ulong)0x4UL;


        public partial struct Sysctlnode
        {
            public uint Flags;
            public int Num;
            public array<sbyte> Name;
            public uint Ver;
            public uint X__rsvd;
            public array<byte> Un;
            public array<byte> X_sysctl_size;
            public array<byte> X_sysctl_func;
            public array<byte> X_sysctl_parent;
            public array<byte> X_sysctl_desc;
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
            public int Tickadj;
            public int Stathz;
            public int Profhz;
        }
    }
}}}}}}
