// cgo -godefs types_solaris.go | go run mkpost.go
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build amd64,solaris

// package unix -- go2cs converted at 2020 October 09 06:00:47 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\ztypes_solaris_amd64.go

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
        public static readonly ulong PathMax = (ulong)0x400UL;
        public static readonly ulong MaxHostNameLen = (ulong)0x100UL;


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

        public partial struct Timeval32
        {
            public int Sec;
            public int Usec;
        }

        public partial struct Tms
        {
            public long Utime;
            public long Stime;
            public long Cutime;
            public long Cstime;
        }

        public partial struct Utimbuf
        {
            public long Actime;
            public long Modtime;
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
            public ulong Cur;
            public ulong Max;
        }

        private partial struct _Gid_t // : uint
        {
        }

        public partial struct Stat_t
        {
            public ulong Dev;
            public ulong Ino;
            public uint Mode;
            public uint Nlink;
            public uint Uid;
            public uint Gid;
            public ulong Rdev;
            public long Size;
            public Timespec Atim;
            public Timespec Mtim;
            public Timespec Ctim;
            public int Blksize;
            public array<byte> _;
            public long Blocks;
            public array<sbyte> Fstype;
        }

        public partial struct Flock_t
        {
            public short Type;
            public short Whence;
            public array<byte> _;
            public long Start;
            public long Len;
            public int Sysid;
            public int Pid;
            public array<long> Pad;
        }

        public partial struct Dirent
        {
            public ulong Ino;
            public long Off;
            public ushort Reclen;
            public array<sbyte> Name;
            public array<byte> _;
        }

        private partial struct _Fsblkcnt_t // : ulong
        {
        }

        public partial struct Statvfs_t
        {
            public ulong Bsize;
            public ulong Frsize;
            public ulong Blocks;
            public ulong Bfree;
            public ulong Bavail;
            public ulong Files;
            public ulong Ffree;
            public ulong Favail;
            public ulong Fsid;
            public array<sbyte> Basetype;
            public ulong Flag;
            public ulong Namemax;
            public array<sbyte> Fstr;
        }

        public partial struct RawSockaddrInet4
        {
            public ushort Family;
            public ushort Port;
            public array<byte> Addr; /* in_addr */
            public array<sbyte> Zero;
        }

        public partial struct RawSockaddrInet6
        {
            public ushort Family;
            public ushort Port;
            public uint Flowinfo;
            public array<byte> Addr; /* in6_addr */
            public uint Scope_id;
            public uint X__sin6_src_id;
        }

        public partial struct RawSockaddrUnix
        {
            public ushort Family;
            public array<sbyte> Path;
        }

        public partial struct RawSockaddrDatalink
        {
            public ushort Family;
            public ushort Index;
            public byte Type;
            public byte Nlen;
            public byte Alen;
            public byte Slen;
            public array<sbyte> Data;
        }

        public partial struct RawSockaddr
        {
            public ushort Family;
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
            public ptr<sbyte> Base;
            public ulong Len;
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
            public array<byte> _;
            public ptr<Iovec> Iov;
            public int Iovlen;
            public array<byte> _;
            public ptr<sbyte> Accrights;
            public int Accrightslen;
            public array<byte> _;
        }

        public partial struct Cmsghdr
        {
            public uint Len;
            public int Level;
            public int Type;
        }

        public partial struct Inet4Pktinfo
        {
            public uint Ifindex;
            public array<byte> Spec_dst; /* in_addr */
            public array<byte> Addr; /* in_addr */
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
            public array<uint> X__icmp6_filt;
        }

        public static readonly ulong SizeofSockaddrInet4 = (ulong)0x10UL;
        public static readonly ulong SizeofSockaddrInet6 = (ulong)0x20UL;
        public static readonly ulong SizeofSockaddrAny = (ulong)0xfcUL;
        public static readonly ulong SizeofSockaddrUnix = (ulong)0x6eUL;
        public static readonly ulong SizeofSockaddrDatalink = (ulong)0xfcUL;
        public static readonly ulong SizeofLinger = (ulong)0x8UL;
        public static readonly ulong SizeofIPMreq = (ulong)0x8UL;
        public static readonly ulong SizeofIPv6Mreq = (ulong)0x14UL;
        public static readonly ulong SizeofMsghdr = (ulong)0x30UL;
        public static readonly ulong SizeofCmsghdr = (ulong)0xcUL;
        public static readonly ulong SizeofInet4Pktinfo = (ulong)0xcUL;
        public static readonly ulong SizeofInet6Pktinfo = (ulong)0x14UL;
        public static readonly ulong SizeofIPv6MTUInfo = (ulong)0x24UL;
        public static readonly ulong SizeofICMPv6Filter = (ulong)0x20UL;


        public partial struct FdSet
        {
            public array<long> Bits;
        }

        public partial struct Utsname
        {
            public array<byte> Sysname;
            public array<byte> Nodename;
            public array<byte> Release;
            public array<byte> Version;
            public array<byte> Machine;
        }

        public partial struct Ustat_t
        {
            public long Tfree;
            public ulong Tinode;
            public array<sbyte> Fname;
            public array<sbyte> Fpack;
            public array<byte> _;
        }

        public static readonly ulong AT_FDCWD = (ulong)0xffd19553UL;
        public static readonly ulong AT_SYMLINK_NOFOLLOW = (ulong)0x1000UL;
        public static readonly ulong AT_SYMLINK_FOLLOW = (ulong)0x2000UL;
        public static readonly ulong AT_REMOVEDIR = (ulong)0x1UL;
        public static readonly ulong AT_EACCESS = (ulong)0x4UL;


        public static readonly ulong SizeofIfMsghdr = (ulong)0x54UL;
        public static readonly ulong SizeofIfData = (ulong)0x44UL;
        public static readonly ulong SizeofIfaMsghdr = (ulong)0x14UL;
        public static readonly ulong SizeofRtMsghdr = (ulong)0x4cUL;
        public static readonly ulong SizeofRtMetrics = (ulong)0x28UL;


        public partial struct IfMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public array<byte> _;
            public IfData Data;
        }

        public partial struct IfData
        {
            public byte Type;
            public byte Addrlen;
            public byte Hdrlen;
            public array<byte> _;
            public uint Mtu;
            public uint Metric;
            public uint Baudrate;
            public uint Ipackets;
            public uint Ierrors;
            public uint Opackets;
            public uint Oerrors;
            public uint Collisions;
            public uint Ibytes;
            public uint Obytes;
            public uint Imcasts;
            public uint Omcasts;
            public uint Iqdrops;
            public uint Noproto;
            public Timeval32 Lastchange;
        }

        public partial struct IfaMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public int Addrs;
            public int Flags;
            public ushort Index;
            public array<byte> _;
            public int Metric;
        }

        public partial struct RtMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public ushort Index;
            public array<byte> _;
            public int Flags;
            public int Addrs;
            public int Pid;
            public int Seq;
            public int Errno;
            public int Use;
            public uint Inits;
            public RtMetrics Rmx;
        }

        public partial struct RtMetrics
        {
            public uint Locks;
            public uint Mtu;
            public uint Hopcount;
            public uint Expire;
            public uint Recvpipe;
            public uint Sendpipe;
            public uint Ssthresh;
            public uint Rtt;
            public uint Rttvar;
            public uint Pksent;
        }

        public static readonly ulong SizeofBpfVersion = (ulong)0x4UL;
        public static readonly ulong SizeofBpfStat = (ulong)0x80UL;
        public static readonly ulong SizeofBpfProgram = (ulong)0x10UL;
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
            public array<byte> _;
            public ptr<BpfInsn> Insns;
        }

        public partial struct BpfInsn
        {
            public ushort Code;
            public byte Jt;
            public byte Jf;
            public uint K;
        }

        public partial struct BpfTimeval
        {
            public int Sec;
            public int Usec;
        }

        public partial struct BpfHdr
        {
            public BpfTimeval Tstamp;
            public uint Caplen;
            public uint Datalen;
            public ushort Hdrlen;
            public array<byte> _;
        }

        public partial struct Termios
        {
            public uint Iflag;
            public uint Oflag;
            public uint Cflag;
            public uint Lflag;
            public array<byte> Cc;
            public array<byte> _;
        }

        public partial struct Termio
        {
            public ushort Iflag;
            public ushort Oflag;
            public ushort Cflag;
            public ushort Lflag;
            public sbyte Line;
            public array<byte> Cc;
            public array<byte> _;
        }

        public partial struct Winsize
        {
            public ushort Row;
            public ushort Col;
            public ushort Xpixel;
            public ushort Ypixel;
        }

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

    }
}}}}}}