// go run linux/mksysnum.go -Wall -Werror -static -I/tmp/include /tmp/include/asm/unistd.h
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build ppc64le,linux

// package unix -- go2cs converted at 2020 October 08 04:53:24 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zsysnum_linux_ppc64le.go

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
        public static readonly long SYS_RESTART_SYSCALL = (long)0L;
        public static readonly long SYS_EXIT = (long)1L;
        public static readonly long SYS_FORK = (long)2L;
        public static readonly long SYS_READ = (long)3L;
        public static readonly long SYS_WRITE = (long)4L;
        public static readonly long SYS_OPEN = (long)5L;
        public static readonly long SYS_CLOSE = (long)6L;
        public static readonly long SYS_WAITPID = (long)7L;
        public static readonly long SYS_CREAT = (long)8L;
        public static readonly long SYS_LINK = (long)9L;
        public static readonly long SYS_UNLINK = (long)10L;
        public static readonly long SYS_EXECVE = (long)11L;
        public static readonly long SYS_CHDIR = (long)12L;
        public static readonly long SYS_TIME = (long)13L;
        public static readonly long SYS_MKNOD = (long)14L;
        public static readonly long SYS_CHMOD = (long)15L;
        public static readonly long SYS_LCHOWN = (long)16L;
        public static readonly long SYS_BREAK = (long)17L;
        public static readonly long SYS_OLDSTAT = (long)18L;
        public static readonly long SYS_LSEEK = (long)19L;
        public static readonly long SYS_GETPID = (long)20L;
        public static readonly long SYS_MOUNT = (long)21L;
        public static readonly long SYS_UMOUNT = (long)22L;
        public static readonly long SYS_SETUID = (long)23L;
        public static readonly long SYS_GETUID = (long)24L;
        public static readonly long SYS_STIME = (long)25L;
        public static readonly long SYS_PTRACE = (long)26L;
        public static readonly long SYS_ALARM = (long)27L;
        public static readonly long SYS_OLDFSTAT = (long)28L;
        public static readonly long SYS_PAUSE = (long)29L;
        public static readonly long SYS_UTIME = (long)30L;
        public static readonly long SYS_STTY = (long)31L;
        public static readonly long SYS_GTTY = (long)32L;
        public static readonly long SYS_ACCESS = (long)33L;
        public static readonly long SYS_NICE = (long)34L;
        public static readonly long SYS_FTIME = (long)35L;
        public static readonly long SYS_SYNC = (long)36L;
        public static readonly long SYS_KILL = (long)37L;
        public static readonly long SYS_RENAME = (long)38L;
        public static readonly long SYS_MKDIR = (long)39L;
        public static readonly long SYS_RMDIR = (long)40L;
        public static readonly long SYS_DUP = (long)41L;
        public static readonly long SYS_PIPE = (long)42L;
        public static readonly long SYS_TIMES = (long)43L;
        public static readonly long SYS_PROF = (long)44L;
        public static readonly long SYS_BRK = (long)45L;
        public static readonly long SYS_SETGID = (long)46L;
        public static readonly long SYS_GETGID = (long)47L;
        public static readonly long SYS_SIGNAL = (long)48L;
        public static readonly long SYS_GETEUID = (long)49L;
        public static readonly long SYS_GETEGID = (long)50L;
        public static readonly long SYS_ACCT = (long)51L;
        public static readonly long SYS_UMOUNT2 = (long)52L;
        public static readonly long SYS_LOCK = (long)53L;
        public static readonly long SYS_IOCTL = (long)54L;
        public static readonly long SYS_FCNTL = (long)55L;
        public static readonly long SYS_MPX = (long)56L;
        public static readonly long SYS_SETPGID = (long)57L;
        public static readonly long SYS_ULIMIT = (long)58L;
        public static readonly long SYS_OLDOLDUNAME = (long)59L;
        public static readonly long SYS_UMASK = (long)60L;
        public static readonly long SYS_CHROOT = (long)61L;
        public static readonly long SYS_USTAT = (long)62L;
        public static readonly long SYS_DUP2 = (long)63L;
        public static readonly long SYS_GETPPID = (long)64L;
        public static readonly long SYS_GETPGRP = (long)65L;
        public static readonly long SYS_SETSID = (long)66L;
        public static readonly long SYS_SIGACTION = (long)67L;
        public static readonly long SYS_SGETMASK = (long)68L;
        public static readonly long SYS_SSETMASK = (long)69L;
        public static readonly long SYS_SETREUID = (long)70L;
        public static readonly long SYS_SETREGID = (long)71L;
        public static readonly long SYS_SIGSUSPEND = (long)72L;
        public static readonly long SYS_SIGPENDING = (long)73L;
        public static readonly long SYS_SETHOSTNAME = (long)74L;
        public static readonly long SYS_SETRLIMIT = (long)75L;
        public static readonly long SYS_GETRLIMIT = (long)76L;
        public static readonly long SYS_GETRUSAGE = (long)77L;
        public static readonly long SYS_GETTIMEOFDAY = (long)78L;
        public static readonly long SYS_SETTIMEOFDAY = (long)79L;
        public static readonly long SYS_GETGROUPS = (long)80L;
        public static readonly long SYS_SETGROUPS = (long)81L;
        public static readonly long SYS_SELECT = (long)82L;
        public static readonly long SYS_SYMLINK = (long)83L;
        public static readonly long SYS_OLDLSTAT = (long)84L;
        public static readonly long SYS_READLINK = (long)85L;
        public static readonly long SYS_USELIB = (long)86L;
        public static readonly long SYS_SWAPON = (long)87L;
        public static readonly long SYS_REBOOT = (long)88L;
        public static readonly long SYS_READDIR = (long)89L;
        public static readonly long SYS_MMAP = (long)90L;
        public static readonly long SYS_MUNMAP = (long)91L;
        public static readonly long SYS_TRUNCATE = (long)92L;
        public static readonly long SYS_FTRUNCATE = (long)93L;
        public static readonly long SYS_FCHMOD = (long)94L;
        public static readonly long SYS_FCHOWN = (long)95L;
        public static readonly long SYS_GETPRIORITY = (long)96L;
        public static readonly long SYS_SETPRIORITY = (long)97L;
        public static readonly long SYS_PROFIL = (long)98L;
        public static readonly long SYS_STATFS = (long)99L;
        public static readonly long SYS_FSTATFS = (long)100L;
        public static readonly long SYS_IOPERM = (long)101L;
        public static readonly long SYS_SOCKETCALL = (long)102L;
        public static readonly long SYS_SYSLOG = (long)103L;
        public static readonly long SYS_SETITIMER = (long)104L;
        public static readonly long SYS_GETITIMER = (long)105L;
        public static readonly long SYS_STAT = (long)106L;
        public static readonly long SYS_LSTAT = (long)107L;
        public static readonly long SYS_FSTAT = (long)108L;
        public static readonly long SYS_OLDUNAME = (long)109L;
        public static readonly long SYS_IOPL = (long)110L;
        public static readonly long SYS_VHANGUP = (long)111L;
        public static readonly long SYS_IDLE = (long)112L;
        public static readonly long SYS_VM86 = (long)113L;
        public static readonly long SYS_WAIT4 = (long)114L;
        public static readonly long SYS_SWAPOFF = (long)115L;
        public static readonly long SYS_SYSINFO = (long)116L;
        public static readonly long SYS_IPC = (long)117L;
        public static readonly long SYS_FSYNC = (long)118L;
        public static readonly long SYS_SIGRETURN = (long)119L;
        public static readonly long SYS_CLONE = (long)120L;
        public static readonly long SYS_SETDOMAINNAME = (long)121L;
        public static readonly long SYS_UNAME = (long)122L;
        public static readonly long SYS_MODIFY_LDT = (long)123L;
        public static readonly long SYS_ADJTIMEX = (long)124L;
        public static readonly long SYS_MPROTECT = (long)125L;
        public static readonly long SYS_SIGPROCMASK = (long)126L;
        public static readonly long SYS_CREATE_MODULE = (long)127L;
        public static readonly long SYS_INIT_MODULE = (long)128L;
        public static readonly long SYS_DELETE_MODULE = (long)129L;
        public static readonly long SYS_GET_KERNEL_SYMS = (long)130L;
        public static readonly long SYS_QUOTACTL = (long)131L;
        public static readonly long SYS_GETPGID = (long)132L;
        public static readonly long SYS_FCHDIR = (long)133L;
        public static readonly long SYS_BDFLUSH = (long)134L;
        public static readonly long SYS_SYSFS = (long)135L;
        public static readonly long SYS_PERSONALITY = (long)136L;
        public static readonly long SYS_AFS_SYSCALL = (long)137L;
        public static readonly long SYS_SETFSUID = (long)138L;
        public static readonly long SYS_SETFSGID = (long)139L;
        public static readonly long SYS__LLSEEK = (long)140L;
        public static readonly long SYS_GETDENTS = (long)141L;
        public static readonly long SYS__NEWSELECT = (long)142L;
        public static readonly long SYS_FLOCK = (long)143L;
        public static readonly long SYS_MSYNC = (long)144L;
        public static readonly long SYS_READV = (long)145L;
        public static readonly long SYS_WRITEV = (long)146L;
        public static readonly long SYS_GETSID = (long)147L;
        public static readonly long SYS_FDATASYNC = (long)148L;
        public static readonly long SYS__SYSCTL = (long)149L;
        public static readonly long SYS_MLOCK = (long)150L;
        public static readonly long SYS_MUNLOCK = (long)151L;
        public static readonly long SYS_MLOCKALL = (long)152L;
        public static readonly long SYS_MUNLOCKALL = (long)153L;
        public static readonly long SYS_SCHED_SETPARAM = (long)154L;
        public static readonly long SYS_SCHED_GETPARAM = (long)155L;
        public static readonly long SYS_SCHED_SETSCHEDULER = (long)156L;
        public static readonly long SYS_SCHED_GETSCHEDULER = (long)157L;
        public static readonly long SYS_SCHED_YIELD = (long)158L;
        public static readonly long SYS_SCHED_GET_PRIORITY_MAX = (long)159L;
        public static readonly long SYS_SCHED_GET_PRIORITY_MIN = (long)160L;
        public static readonly long SYS_SCHED_RR_GET_INTERVAL = (long)161L;
        public static readonly long SYS_NANOSLEEP = (long)162L;
        public static readonly long SYS_MREMAP = (long)163L;
        public static readonly long SYS_SETRESUID = (long)164L;
        public static readonly long SYS_GETRESUID = (long)165L;
        public static readonly long SYS_QUERY_MODULE = (long)166L;
        public static readonly long SYS_POLL = (long)167L;
        public static readonly long SYS_NFSSERVCTL = (long)168L;
        public static readonly long SYS_SETRESGID = (long)169L;
        public static readonly long SYS_GETRESGID = (long)170L;
        public static readonly long SYS_PRCTL = (long)171L;
        public static readonly long SYS_RT_SIGRETURN = (long)172L;
        public static readonly long SYS_RT_SIGACTION = (long)173L;
        public static readonly long SYS_RT_SIGPROCMASK = (long)174L;
        public static readonly long SYS_RT_SIGPENDING = (long)175L;
        public static readonly long SYS_RT_SIGTIMEDWAIT = (long)176L;
        public static readonly long SYS_RT_SIGQUEUEINFO = (long)177L;
        public static readonly long SYS_RT_SIGSUSPEND = (long)178L;
        public static readonly long SYS_PREAD64 = (long)179L;
        public static readonly long SYS_PWRITE64 = (long)180L;
        public static readonly long SYS_CHOWN = (long)181L;
        public static readonly long SYS_GETCWD = (long)182L;
        public static readonly long SYS_CAPGET = (long)183L;
        public static readonly long SYS_CAPSET = (long)184L;
        public static readonly long SYS_SIGALTSTACK = (long)185L;
        public static readonly long SYS_SENDFILE = (long)186L;
        public static readonly long SYS_GETPMSG = (long)187L;
        public static readonly long SYS_PUTPMSG = (long)188L;
        public static readonly long SYS_VFORK = (long)189L;
        public static readonly long SYS_UGETRLIMIT = (long)190L;
        public static readonly long SYS_READAHEAD = (long)191L;
        public static readonly long SYS_PCICONFIG_READ = (long)198L;
        public static readonly long SYS_PCICONFIG_WRITE = (long)199L;
        public static readonly long SYS_PCICONFIG_IOBASE = (long)200L;
        public static readonly long SYS_MULTIPLEXER = (long)201L;
        public static readonly long SYS_GETDENTS64 = (long)202L;
        public static readonly long SYS_PIVOT_ROOT = (long)203L;
        public static readonly long SYS_MADVISE = (long)205L;
        public static readonly long SYS_MINCORE = (long)206L;
        public static readonly long SYS_GETTID = (long)207L;
        public static readonly long SYS_TKILL = (long)208L;
        public static readonly long SYS_SETXATTR = (long)209L;
        public static readonly long SYS_LSETXATTR = (long)210L;
        public static readonly long SYS_FSETXATTR = (long)211L;
        public static readonly long SYS_GETXATTR = (long)212L;
        public static readonly long SYS_LGETXATTR = (long)213L;
        public static readonly long SYS_FGETXATTR = (long)214L;
        public static readonly long SYS_LISTXATTR = (long)215L;
        public static readonly long SYS_LLISTXATTR = (long)216L;
        public static readonly long SYS_FLISTXATTR = (long)217L;
        public static readonly long SYS_REMOVEXATTR = (long)218L;
        public static readonly long SYS_LREMOVEXATTR = (long)219L;
        public static readonly long SYS_FREMOVEXATTR = (long)220L;
        public static readonly long SYS_FUTEX = (long)221L;
        public static readonly long SYS_SCHED_SETAFFINITY = (long)222L;
        public static readonly long SYS_SCHED_GETAFFINITY = (long)223L;
        public static readonly long SYS_TUXCALL = (long)225L;
        public static readonly long SYS_IO_SETUP = (long)227L;
        public static readonly long SYS_IO_DESTROY = (long)228L;
        public static readonly long SYS_IO_GETEVENTS = (long)229L;
        public static readonly long SYS_IO_SUBMIT = (long)230L;
        public static readonly long SYS_IO_CANCEL = (long)231L;
        public static readonly long SYS_SET_TID_ADDRESS = (long)232L;
        public static readonly long SYS_FADVISE64 = (long)233L;
        public static readonly long SYS_EXIT_GROUP = (long)234L;
        public static readonly long SYS_LOOKUP_DCOOKIE = (long)235L;
        public static readonly long SYS_EPOLL_CREATE = (long)236L;
        public static readonly long SYS_EPOLL_CTL = (long)237L;
        public static readonly long SYS_EPOLL_WAIT = (long)238L;
        public static readonly long SYS_REMAP_FILE_PAGES = (long)239L;
        public static readonly long SYS_TIMER_CREATE = (long)240L;
        public static readonly long SYS_TIMER_SETTIME = (long)241L;
        public static readonly long SYS_TIMER_GETTIME = (long)242L;
        public static readonly long SYS_TIMER_GETOVERRUN = (long)243L;
        public static readonly long SYS_TIMER_DELETE = (long)244L;
        public static readonly long SYS_CLOCK_SETTIME = (long)245L;
        public static readonly long SYS_CLOCK_GETTIME = (long)246L;
        public static readonly long SYS_CLOCK_GETRES = (long)247L;
        public static readonly long SYS_CLOCK_NANOSLEEP = (long)248L;
        public static readonly long SYS_SWAPCONTEXT = (long)249L;
        public static readonly long SYS_TGKILL = (long)250L;
        public static readonly long SYS_UTIMES = (long)251L;
        public static readonly long SYS_STATFS64 = (long)252L;
        public static readonly long SYS_FSTATFS64 = (long)253L;
        public static readonly long SYS_RTAS = (long)255L;
        public static readonly long SYS_SYS_DEBUG_SETCONTEXT = (long)256L;
        public static readonly long SYS_MIGRATE_PAGES = (long)258L;
        public static readonly long SYS_MBIND = (long)259L;
        public static readonly long SYS_GET_MEMPOLICY = (long)260L;
        public static readonly long SYS_SET_MEMPOLICY = (long)261L;
        public static readonly long SYS_MQ_OPEN = (long)262L;
        public static readonly long SYS_MQ_UNLINK = (long)263L;
        public static readonly long SYS_MQ_TIMEDSEND = (long)264L;
        public static readonly long SYS_MQ_TIMEDRECEIVE = (long)265L;
        public static readonly long SYS_MQ_NOTIFY = (long)266L;
        public static readonly long SYS_MQ_GETSETATTR = (long)267L;
        public static readonly long SYS_KEXEC_LOAD = (long)268L;
        public static readonly long SYS_ADD_KEY = (long)269L;
        public static readonly long SYS_REQUEST_KEY = (long)270L;
        public static readonly long SYS_KEYCTL = (long)271L;
        public static readonly long SYS_WAITID = (long)272L;
        public static readonly long SYS_IOPRIO_SET = (long)273L;
        public static readonly long SYS_IOPRIO_GET = (long)274L;
        public static readonly long SYS_INOTIFY_INIT = (long)275L;
        public static readonly long SYS_INOTIFY_ADD_WATCH = (long)276L;
        public static readonly long SYS_INOTIFY_RM_WATCH = (long)277L;
        public static readonly long SYS_SPU_RUN = (long)278L;
        public static readonly long SYS_SPU_CREATE = (long)279L;
        public static readonly long SYS_PSELECT6 = (long)280L;
        public static readonly long SYS_PPOLL = (long)281L;
        public static readonly long SYS_UNSHARE = (long)282L;
        public static readonly long SYS_SPLICE = (long)283L;
        public static readonly long SYS_TEE = (long)284L;
        public static readonly long SYS_VMSPLICE = (long)285L;
        public static readonly long SYS_OPENAT = (long)286L;
        public static readonly long SYS_MKDIRAT = (long)287L;
        public static readonly long SYS_MKNODAT = (long)288L;
        public static readonly long SYS_FCHOWNAT = (long)289L;
        public static readonly long SYS_FUTIMESAT = (long)290L;
        public static readonly long SYS_NEWFSTATAT = (long)291L;
        public static readonly long SYS_UNLINKAT = (long)292L;
        public static readonly long SYS_RENAMEAT = (long)293L;
        public static readonly long SYS_LINKAT = (long)294L;
        public static readonly long SYS_SYMLINKAT = (long)295L;
        public static readonly long SYS_READLINKAT = (long)296L;
        public static readonly long SYS_FCHMODAT = (long)297L;
        public static readonly long SYS_FACCESSAT = (long)298L;
        public static readonly long SYS_GET_ROBUST_LIST = (long)299L;
        public static readonly long SYS_SET_ROBUST_LIST = (long)300L;
        public static readonly long SYS_MOVE_PAGES = (long)301L;
        public static readonly long SYS_GETCPU = (long)302L;
        public static readonly long SYS_EPOLL_PWAIT = (long)303L;
        public static readonly long SYS_UTIMENSAT = (long)304L;
        public static readonly long SYS_SIGNALFD = (long)305L;
        public static readonly long SYS_TIMERFD_CREATE = (long)306L;
        public static readonly long SYS_EVENTFD = (long)307L;
        public static readonly long SYS_SYNC_FILE_RANGE2 = (long)308L;
        public static readonly long SYS_FALLOCATE = (long)309L;
        public static readonly long SYS_SUBPAGE_PROT = (long)310L;
        public static readonly long SYS_TIMERFD_SETTIME = (long)311L;
        public static readonly long SYS_TIMERFD_GETTIME = (long)312L;
        public static readonly long SYS_SIGNALFD4 = (long)313L;
        public static readonly long SYS_EVENTFD2 = (long)314L;
        public static readonly long SYS_EPOLL_CREATE1 = (long)315L;
        public static readonly long SYS_DUP3 = (long)316L;
        public static readonly long SYS_PIPE2 = (long)317L;
        public static readonly long SYS_INOTIFY_INIT1 = (long)318L;
        public static readonly long SYS_PERF_EVENT_OPEN = (long)319L;
        public static readonly long SYS_PREADV = (long)320L;
        public static readonly long SYS_PWRITEV = (long)321L;
        public static readonly long SYS_RT_TGSIGQUEUEINFO = (long)322L;
        public static readonly long SYS_FANOTIFY_INIT = (long)323L;
        public static readonly long SYS_FANOTIFY_MARK = (long)324L;
        public static readonly long SYS_PRLIMIT64 = (long)325L;
        public static readonly long SYS_SOCKET = (long)326L;
        public static readonly long SYS_BIND = (long)327L;
        public static readonly long SYS_CONNECT = (long)328L;
        public static readonly long SYS_LISTEN = (long)329L;
        public static readonly long SYS_ACCEPT = (long)330L;
        public static readonly long SYS_GETSOCKNAME = (long)331L;
        public static readonly long SYS_GETPEERNAME = (long)332L;
        public static readonly long SYS_SOCKETPAIR = (long)333L;
        public static readonly long SYS_SEND = (long)334L;
        public static readonly long SYS_SENDTO = (long)335L;
        public static readonly long SYS_RECV = (long)336L;
        public static readonly long SYS_RECVFROM = (long)337L;
        public static readonly long SYS_SHUTDOWN = (long)338L;
        public static readonly long SYS_SETSOCKOPT = (long)339L;
        public static readonly long SYS_GETSOCKOPT = (long)340L;
        public static readonly long SYS_SENDMSG = (long)341L;
        public static readonly long SYS_RECVMSG = (long)342L;
        public static readonly long SYS_RECVMMSG = (long)343L;
        public static readonly long SYS_ACCEPT4 = (long)344L;
        public static readonly long SYS_NAME_TO_HANDLE_AT = (long)345L;
        public static readonly long SYS_OPEN_BY_HANDLE_AT = (long)346L;
        public static readonly long SYS_CLOCK_ADJTIME = (long)347L;
        public static readonly long SYS_SYNCFS = (long)348L;
        public static readonly long SYS_SENDMMSG = (long)349L;
        public static readonly long SYS_SETNS = (long)350L;
        public static readonly long SYS_PROCESS_VM_READV = (long)351L;
        public static readonly long SYS_PROCESS_VM_WRITEV = (long)352L;
        public static readonly long SYS_FINIT_MODULE = (long)353L;
        public static readonly long SYS_KCMP = (long)354L;
        public static readonly long SYS_SCHED_SETATTR = (long)355L;
        public static readonly long SYS_SCHED_GETATTR = (long)356L;
        public static readonly long SYS_RENAMEAT2 = (long)357L;
        public static readonly long SYS_SECCOMP = (long)358L;
        public static readonly long SYS_GETRANDOM = (long)359L;
        public static readonly long SYS_MEMFD_CREATE = (long)360L;
        public static readonly long SYS_BPF = (long)361L;
        public static readonly long SYS_EXECVEAT = (long)362L;
        public static readonly long SYS_SWITCH_ENDIAN = (long)363L;
        public static readonly long SYS_USERFAULTFD = (long)364L;
        public static readonly long SYS_MEMBARRIER = (long)365L;
        public static readonly long SYS_MLOCK2 = (long)378L;
        public static readonly long SYS_COPY_FILE_RANGE = (long)379L;
        public static readonly long SYS_PREADV2 = (long)380L;
        public static readonly long SYS_PWRITEV2 = (long)381L;
        public static readonly long SYS_KEXEC_FILE_LOAD = (long)382L;
        public static readonly long SYS_STATX = (long)383L;
        public static readonly long SYS_PKEY_ALLOC = (long)384L;
        public static readonly long SYS_PKEY_FREE = (long)385L;
        public static readonly long SYS_PKEY_MPROTECT = (long)386L;
        public static readonly long SYS_RSEQ = (long)387L;
        public static readonly long SYS_IO_PGETEVENTS = (long)388L;
        public static readonly long SYS_SEMTIMEDOP = (long)392L;
        public static readonly long SYS_SEMGET = (long)393L;
        public static readonly long SYS_SEMCTL = (long)394L;
        public static readonly long SYS_SHMGET = (long)395L;
        public static readonly long SYS_SHMCTL = (long)396L;
        public static readonly long SYS_SHMAT = (long)397L;
        public static readonly long SYS_SHMDT = (long)398L;
        public static readonly long SYS_MSGGET = (long)399L;
        public static readonly long SYS_MSGSND = (long)400L;
        public static readonly long SYS_MSGRCV = (long)401L;
        public static readonly long SYS_MSGCTL = (long)402L;
        public static readonly long SYS_PIDFD_SEND_SIGNAL = (long)424L;
        public static readonly long SYS_IO_URING_SETUP = (long)425L;
        public static readonly long SYS_IO_URING_ENTER = (long)426L;
        public static readonly long SYS_IO_URING_REGISTER = (long)427L;
        public static readonly long SYS_OPEN_TREE = (long)428L;
        public static readonly long SYS_MOVE_MOUNT = (long)429L;
        public static readonly long SYS_FSOPEN = (long)430L;
        public static readonly long SYS_FSCONFIG = (long)431L;
        public static readonly long SYS_FSMOUNT = (long)432L;
        public static readonly long SYS_FSPICK = (long)433L;
        public static readonly long SYS_PIDFD_OPEN = (long)434L;
        public static readonly long SYS_CLONE3 = (long)435L;
        public static readonly long SYS_OPENAT2 = (long)437L;
        public static readonly long SYS_PIDFD_GETFD = (long)438L;

    }
}}}}}}
