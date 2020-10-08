// Created by cgo -godefs - DO NOT EDIT
// cgo -godefs types_openbsd.go

// +build amd64,openbsd

// package syscall -- go2cs converted at 2020 October 08 03:30:41 UTC
// import "syscall" ==> using syscall = go.syscall_package
// Original source: C:\Go\src\syscall\ztypes_openbsd_amd64.go

using static go.builtin;

namespace go
{
    public static partial class syscall_package
    {
        private static readonly ulong sizeofPtr = (ulong)0x8UL;
        private static readonly ulong sizeofShort = (ulong)0x2UL;
        private static readonly ulong sizeofInt = (ulong)0x4UL;
        private static readonly ulong sizeofLong = (ulong)0x8UL;
        private static readonly ulong sizeofLongLong = (ulong)0x8UL;


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
            public ulong Cur;
            public ulong Max;
        }

        private partial struct _Gid_t // : uint
        {
        }

        public static readonly ulong S_IFMT = (ulong)0xf000UL;
        public static readonly ulong S_IFIFO = (ulong)0x1000UL;
        public static readonly ulong S_IFCHR = (ulong)0x2000UL;
        public static readonly ulong S_IFDIR = (ulong)0x4000UL;
        public static readonly ulong S_IFBLK = (ulong)0x6000UL;
        public static readonly ulong S_IFREG = (ulong)0x8000UL;
        public static readonly ulong S_IFLNK = (ulong)0xa000UL;
        public static readonly ulong S_IFSOCK = (ulong)0xc000UL;
        public static readonly ulong S_ISUID = (ulong)0x800UL;
        public static readonly ulong S_ISGID = (ulong)0x400UL;
        public static readonly ulong S_ISVTX = (ulong)0x200UL;
        public static readonly ulong S_IRUSR = (ulong)0x100UL;
        public static readonly ulong S_IWUSR = (ulong)0x80UL;
        public static readonly ulong S_IXUSR = (ulong)0x40UL;
        public static readonly ulong S_IRWXG = (ulong)0x38UL;
        public static readonly ulong S_IRWXO = (ulong)0x7UL;


        public partial struct Stat_t
        {
            public uint Mode;
            public int Dev;
            public ulong Ino;
            public uint Nlink;
            public uint Uid;
            public uint Gid;
            public int Rdev;
            public Timespec Atim;
            public Timespec Mtim;
            public Timespec Ctim;
            public long Size;
            public long Blocks;
            public uint Blksize;
            public uint Flags;
            public uint Gen;
            public array<byte> Pad_cgo_0;
            public Timespec X__st_birthtim;
        }

        public partial struct Statfs_t
        {
            public uint F_flags;
            public uint F_bsize;
            public uint F_iosize;
            public array<byte> Pad_cgo_0;
            public ulong F_blocks;
            public ulong F_bfree;
            public long F_bavail;
            public ulong F_files;
            public ulong F_ffree;
            public long F_favail;
            public ulong F_syncwrites;
            public ulong F_syncreads;
            public ulong F_asyncwrites;
            public ulong F_asyncreads;
            public Fsid F_fsid;
            public uint F_namemax;
            public uint F_owner;
            public ulong F_ctime;
            public array<sbyte> F_fstypename;
            public array<sbyte> F_mntonname;
            public array<sbyte> F_mntfromname;
            public array<sbyte> F_mntfromspec;
            public array<byte> Pad_cgo_1;
            public array<byte> Mount_info;
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
            public long Off;
            public ushort Reclen;
            public byte Type;
            public byte Namlen;
            public array<byte> X__d_padding;
            public array<sbyte> Name;
        }

        public partial struct Fsid
        {
            public array<int> Val;
        }

        private static readonly ulong pathMax = (ulong)0x400UL;


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

        public partial struct IPv6Mreq
        {
            public array<byte> Multiaddr; /* in6_addr */
            public uint Interface;
        }

        public partial struct Msghdr
        {
            public ptr<byte> Name;
            public uint Namelen;
            public array<byte> Pad_cgo_0;
            public ptr<Iovec> Iov;
            public uint Iovlen;
            public array<byte> Pad_cgo_1;
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
        public static readonly ulong SizeofSockaddrDatalink = (ulong)0x20UL;
        public static readonly ulong SizeofLinger = (ulong)0x8UL;
        public static readonly ulong SizeofIPMreq = (ulong)0x8UL;
        public static readonly ulong SizeofIPv6Mreq = (ulong)0x14UL;
        public static readonly ulong SizeofMsghdr = (ulong)0x30UL;
        public static readonly ulong SizeofCmsghdr = (ulong)0xcUL;
        public static readonly ulong SizeofInet6Pktinfo = (ulong)0x14UL;
        public static readonly ulong SizeofIPv6MTUInfo = (ulong)0x20UL;
        public static readonly ulong SizeofICMPv6Filter = (ulong)0x20UL;


        public static readonly ulong PTRACE_TRACEME = (ulong)0x0UL;
        public static readonly ulong PTRACE_CONT = (ulong)0x7UL;
        public static readonly ulong PTRACE_KILL = (ulong)0x8UL;


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
            public array<uint> Bits;
        }

        public static readonly ulong SizeofIfMsghdr = (ulong)0xf8UL;
        public static readonly ulong SizeofIfData = (ulong)0xe0UL;
        public static readonly ulong SizeofIfaMsghdr = (ulong)0x18UL;
        public static readonly ulong SizeofIfAnnounceMsghdr = (ulong)0x1aUL;
        public static readonly ulong SizeofRtMsghdr = (ulong)0x60UL;
        public static readonly ulong SizeofRtMetrics = (ulong)0x38UL;


        public partial struct IfMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public ushort Hdrlen;
            public ushort Index;
            public ushort Tableid;
            public byte Pad1;
            public byte Pad2;
            public int Addrs;
            public int Flags;
            public int Xflags;
            public IfData Data;
        }

        public partial struct IfData
        {
            public byte Type;
            public byte Addrlen;
            public byte Hdrlen;
            public byte Link_state;
            public uint Mtu;
            public uint Metric;
            public uint Pad;
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
            public uint Capabilities;
            public array<byte> Pad_cgo_0;
            public Timeval Lastchange;
            public array<Mclpool> Mclpool;
            public array<byte> Pad_cgo_1;
        }

        public partial struct IfaMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public ushort Hdrlen;
            public ushort Index;
            public ushort Tableid;
            public byte Pad1;
            public byte Pad2;
            public int Addrs;
            public int Flags;
            public int Metric;
        }

        public partial struct IfAnnounceMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public ushort Hdrlen;
            public ushort Index;
            public ushort What;
            public array<sbyte> Name;
        }

        public partial struct RtMsghdr
        {
            public ushort Msglen;
            public byte Version;
            public byte Type;
            public ushort Hdrlen;
            public ushort Index;
            public ushort Tableid;
            public byte Priority;
            public byte Mpls;
            public int Addrs;
            public int Flags;
            public int Fmask;
            public int Pid;
            public int Seq;
            public int Errno;
            public uint Inits;
            public RtMetrics Rmx;
        }

        public partial struct RtMetrics
        {
            public ulong Pksent;
            public long Expire;
            public uint Locks;
            public uint Mtu;
            public uint Refcnt;
            public uint Hopcount;
            public uint Recvpipe;
            public uint Sendpipe;
            public uint Ssthresh;
            public uint Rtt;
            public uint Rttvar;
            public uint Pad;
        }

        public partial struct Mclpool
        {
            public int Grown;
            public ushort Alive;
            public ushort Hwm;
            public ushort Cwm;
            public ushort Lwm;
        }

        public static readonly ulong SizeofBpfVersion = (ulong)0x4UL;
        public static readonly ulong SizeofBpfStat = (ulong)0x8UL;
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
            public uint Recv;
            public uint Drop;
        }

        public partial struct BpfProgram
        {
            public uint Len;
            public array<byte> Pad_cgo_0;
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
            public uint Sec;
            public uint Usec;
        }

        private static readonly ulong _AT_FDCWD = (ulong)-0x64UL;


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
    }
}
