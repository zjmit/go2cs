// go run linux/mksysnum.go -Wall -Werror -static -I/tmp/include /tmp/include/asm/unistd.h
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build riscv64,linux

// package unix -- go2cs converted at 2020 October 08 04:53:25 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zsysnum_linux_riscv64.go

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
        public static readonly long SYS_IO_SETUP = (long)0L;
        public static readonly long SYS_IO_DESTROY = (long)1L;
        public static readonly long SYS_IO_SUBMIT = (long)2L;
        public static readonly long SYS_IO_CANCEL = (long)3L;
        public static readonly long SYS_IO_GETEVENTS = (long)4L;
        public static readonly long SYS_SETXATTR = (long)5L;
        public static readonly long SYS_LSETXATTR = (long)6L;
        public static readonly long SYS_FSETXATTR = (long)7L;
        public static readonly long SYS_GETXATTR = (long)8L;
        public static readonly long SYS_LGETXATTR = (long)9L;
        public static readonly long SYS_FGETXATTR = (long)10L;
        public static readonly long SYS_LISTXATTR = (long)11L;
        public static readonly long SYS_LLISTXATTR = (long)12L;
        public static readonly long SYS_FLISTXATTR = (long)13L;
        public static readonly long SYS_REMOVEXATTR = (long)14L;
        public static readonly long SYS_LREMOVEXATTR = (long)15L;
        public static readonly long SYS_FREMOVEXATTR = (long)16L;
        public static readonly long SYS_GETCWD = (long)17L;
        public static readonly long SYS_LOOKUP_DCOOKIE = (long)18L;
        public static readonly long SYS_EVENTFD2 = (long)19L;
        public static readonly long SYS_EPOLL_CREATE1 = (long)20L;
        public static readonly long SYS_EPOLL_CTL = (long)21L;
        public static readonly long SYS_EPOLL_PWAIT = (long)22L;
        public static readonly long SYS_DUP = (long)23L;
        public static readonly long SYS_DUP3 = (long)24L;
        public static readonly long SYS_FCNTL = (long)25L;
        public static readonly long SYS_INOTIFY_INIT1 = (long)26L;
        public static readonly long SYS_INOTIFY_ADD_WATCH = (long)27L;
        public static readonly long SYS_INOTIFY_RM_WATCH = (long)28L;
        public static readonly long SYS_IOCTL = (long)29L;
        public static readonly long SYS_IOPRIO_SET = (long)30L;
        public static readonly long SYS_IOPRIO_GET = (long)31L;
        public static readonly long SYS_FLOCK = (long)32L;
        public static readonly long SYS_MKNODAT = (long)33L;
        public static readonly long SYS_MKDIRAT = (long)34L;
        public static readonly long SYS_UNLINKAT = (long)35L;
        public static readonly long SYS_SYMLINKAT = (long)36L;
        public static readonly long SYS_LINKAT = (long)37L;
        public static readonly long SYS_UMOUNT2 = (long)39L;
        public static readonly long SYS_MOUNT = (long)40L;
        public static readonly long SYS_PIVOT_ROOT = (long)41L;
        public static readonly long SYS_NFSSERVCTL = (long)42L;
        public static readonly long SYS_STATFS = (long)43L;
        public static readonly long SYS_FSTATFS = (long)44L;
        public static readonly long SYS_TRUNCATE = (long)45L;
        public static readonly long SYS_FTRUNCATE = (long)46L;
        public static readonly long SYS_FALLOCATE = (long)47L;
        public static readonly long SYS_FACCESSAT = (long)48L;
        public static readonly long SYS_CHDIR = (long)49L;
        public static readonly long SYS_FCHDIR = (long)50L;
        public static readonly long SYS_CHROOT = (long)51L;
        public static readonly long SYS_FCHMOD = (long)52L;
        public static readonly long SYS_FCHMODAT = (long)53L;
        public static readonly long SYS_FCHOWNAT = (long)54L;
        public static readonly long SYS_FCHOWN = (long)55L;
        public static readonly long SYS_OPENAT = (long)56L;
        public static readonly long SYS_CLOSE = (long)57L;
        public static readonly long SYS_VHANGUP = (long)58L;
        public static readonly long SYS_PIPE2 = (long)59L;
        public static readonly long SYS_QUOTACTL = (long)60L;
        public static readonly long SYS_GETDENTS64 = (long)61L;
        public static readonly long SYS_LSEEK = (long)62L;
        public static readonly long SYS_READ = (long)63L;
        public static readonly long SYS_WRITE = (long)64L;
        public static readonly long SYS_READV = (long)65L;
        public static readonly long SYS_WRITEV = (long)66L;
        public static readonly long SYS_PREAD64 = (long)67L;
        public static readonly long SYS_PWRITE64 = (long)68L;
        public static readonly long SYS_PREADV = (long)69L;
        public static readonly long SYS_PWRITEV = (long)70L;
        public static readonly long SYS_SENDFILE = (long)71L;
        public static readonly long SYS_PSELECT6 = (long)72L;
        public static readonly long SYS_PPOLL = (long)73L;
        public static readonly long SYS_SIGNALFD4 = (long)74L;
        public static readonly long SYS_VMSPLICE = (long)75L;
        public static readonly long SYS_SPLICE = (long)76L;
        public static readonly long SYS_TEE = (long)77L;
        public static readonly long SYS_READLINKAT = (long)78L;
        public static readonly long SYS_FSTATAT = (long)79L;
        public static readonly long SYS_FSTAT = (long)80L;
        public static readonly long SYS_SYNC = (long)81L;
        public static readonly long SYS_FSYNC = (long)82L;
        public static readonly long SYS_FDATASYNC = (long)83L;
        public static readonly long SYS_SYNC_FILE_RANGE = (long)84L;
        public static readonly long SYS_TIMERFD_CREATE = (long)85L;
        public static readonly long SYS_TIMERFD_SETTIME = (long)86L;
        public static readonly long SYS_TIMERFD_GETTIME = (long)87L;
        public static readonly long SYS_UTIMENSAT = (long)88L;
        public static readonly long SYS_ACCT = (long)89L;
        public static readonly long SYS_CAPGET = (long)90L;
        public static readonly long SYS_CAPSET = (long)91L;
        public static readonly long SYS_PERSONALITY = (long)92L;
        public static readonly long SYS_EXIT = (long)93L;
        public static readonly long SYS_EXIT_GROUP = (long)94L;
        public static readonly long SYS_WAITID = (long)95L;
        public static readonly long SYS_SET_TID_ADDRESS = (long)96L;
        public static readonly long SYS_UNSHARE = (long)97L;
        public static readonly long SYS_FUTEX = (long)98L;
        public static readonly long SYS_SET_ROBUST_LIST = (long)99L;
        public static readonly long SYS_GET_ROBUST_LIST = (long)100L;
        public static readonly long SYS_NANOSLEEP = (long)101L;
        public static readonly long SYS_GETITIMER = (long)102L;
        public static readonly long SYS_SETITIMER = (long)103L;
        public static readonly long SYS_KEXEC_LOAD = (long)104L;
        public static readonly long SYS_INIT_MODULE = (long)105L;
        public static readonly long SYS_DELETE_MODULE = (long)106L;
        public static readonly long SYS_TIMER_CREATE = (long)107L;
        public static readonly long SYS_TIMER_GETTIME = (long)108L;
        public static readonly long SYS_TIMER_GETOVERRUN = (long)109L;
        public static readonly long SYS_TIMER_SETTIME = (long)110L;
        public static readonly long SYS_TIMER_DELETE = (long)111L;
        public static readonly long SYS_CLOCK_SETTIME = (long)112L;
        public static readonly long SYS_CLOCK_GETTIME = (long)113L;
        public static readonly long SYS_CLOCK_GETRES = (long)114L;
        public static readonly long SYS_CLOCK_NANOSLEEP = (long)115L;
        public static readonly long SYS_SYSLOG = (long)116L;
        public static readonly long SYS_PTRACE = (long)117L;
        public static readonly long SYS_SCHED_SETPARAM = (long)118L;
        public static readonly long SYS_SCHED_SETSCHEDULER = (long)119L;
        public static readonly long SYS_SCHED_GETSCHEDULER = (long)120L;
        public static readonly long SYS_SCHED_GETPARAM = (long)121L;
        public static readonly long SYS_SCHED_SETAFFINITY = (long)122L;
        public static readonly long SYS_SCHED_GETAFFINITY = (long)123L;
        public static readonly long SYS_SCHED_YIELD = (long)124L;
        public static readonly long SYS_SCHED_GET_PRIORITY_MAX = (long)125L;
        public static readonly long SYS_SCHED_GET_PRIORITY_MIN = (long)126L;
        public static readonly long SYS_SCHED_RR_GET_INTERVAL = (long)127L;
        public static readonly long SYS_RESTART_SYSCALL = (long)128L;
        public static readonly long SYS_KILL = (long)129L;
        public static readonly long SYS_TKILL = (long)130L;
        public static readonly long SYS_TGKILL = (long)131L;
        public static readonly long SYS_SIGALTSTACK = (long)132L;
        public static readonly long SYS_RT_SIGSUSPEND = (long)133L;
        public static readonly long SYS_RT_SIGACTION = (long)134L;
        public static readonly long SYS_RT_SIGPROCMASK = (long)135L;
        public static readonly long SYS_RT_SIGPENDING = (long)136L;
        public static readonly long SYS_RT_SIGTIMEDWAIT = (long)137L;
        public static readonly long SYS_RT_SIGQUEUEINFO = (long)138L;
        public static readonly long SYS_RT_SIGRETURN = (long)139L;
        public static readonly long SYS_SETPRIORITY = (long)140L;
        public static readonly long SYS_GETPRIORITY = (long)141L;
        public static readonly long SYS_REBOOT = (long)142L;
        public static readonly long SYS_SETREGID = (long)143L;
        public static readonly long SYS_SETGID = (long)144L;
        public static readonly long SYS_SETREUID = (long)145L;
        public static readonly long SYS_SETUID = (long)146L;
        public static readonly long SYS_SETRESUID = (long)147L;
        public static readonly long SYS_GETRESUID = (long)148L;
        public static readonly long SYS_SETRESGID = (long)149L;
        public static readonly long SYS_GETRESGID = (long)150L;
        public static readonly long SYS_SETFSUID = (long)151L;
        public static readonly long SYS_SETFSGID = (long)152L;
        public static readonly long SYS_TIMES = (long)153L;
        public static readonly long SYS_SETPGID = (long)154L;
        public static readonly long SYS_GETPGID = (long)155L;
        public static readonly long SYS_GETSID = (long)156L;
        public static readonly long SYS_SETSID = (long)157L;
        public static readonly long SYS_GETGROUPS = (long)158L;
        public static readonly long SYS_SETGROUPS = (long)159L;
        public static readonly long SYS_UNAME = (long)160L;
        public static readonly long SYS_SETHOSTNAME = (long)161L;
        public static readonly long SYS_SETDOMAINNAME = (long)162L;
        public static readonly long SYS_GETRLIMIT = (long)163L;
        public static readonly long SYS_SETRLIMIT = (long)164L;
        public static readonly long SYS_GETRUSAGE = (long)165L;
        public static readonly long SYS_UMASK = (long)166L;
        public static readonly long SYS_PRCTL = (long)167L;
        public static readonly long SYS_GETCPU = (long)168L;
        public static readonly long SYS_GETTIMEOFDAY = (long)169L;
        public static readonly long SYS_SETTIMEOFDAY = (long)170L;
        public static readonly long SYS_ADJTIMEX = (long)171L;
        public static readonly long SYS_GETPID = (long)172L;
        public static readonly long SYS_GETPPID = (long)173L;
        public static readonly long SYS_GETUID = (long)174L;
        public static readonly long SYS_GETEUID = (long)175L;
        public static readonly long SYS_GETGID = (long)176L;
        public static readonly long SYS_GETEGID = (long)177L;
        public static readonly long SYS_GETTID = (long)178L;
        public static readonly long SYS_SYSINFO = (long)179L;
        public static readonly long SYS_MQ_OPEN = (long)180L;
        public static readonly long SYS_MQ_UNLINK = (long)181L;
        public static readonly long SYS_MQ_TIMEDSEND = (long)182L;
        public static readonly long SYS_MQ_TIMEDRECEIVE = (long)183L;
        public static readonly long SYS_MQ_NOTIFY = (long)184L;
        public static readonly long SYS_MQ_GETSETATTR = (long)185L;
        public static readonly long SYS_MSGGET = (long)186L;
        public static readonly long SYS_MSGCTL = (long)187L;
        public static readonly long SYS_MSGRCV = (long)188L;
        public static readonly long SYS_MSGSND = (long)189L;
        public static readonly long SYS_SEMGET = (long)190L;
        public static readonly long SYS_SEMCTL = (long)191L;
        public static readonly long SYS_SEMTIMEDOP = (long)192L;
        public static readonly long SYS_SEMOP = (long)193L;
        public static readonly long SYS_SHMGET = (long)194L;
        public static readonly long SYS_SHMCTL = (long)195L;
        public static readonly long SYS_SHMAT = (long)196L;
        public static readonly long SYS_SHMDT = (long)197L;
        public static readonly long SYS_SOCKET = (long)198L;
        public static readonly long SYS_SOCKETPAIR = (long)199L;
        public static readonly long SYS_BIND = (long)200L;
        public static readonly long SYS_LISTEN = (long)201L;
        public static readonly long SYS_ACCEPT = (long)202L;
        public static readonly long SYS_CONNECT = (long)203L;
        public static readonly long SYS_GETSOCKNAME = (long)204L;
        public static readonly long SYS_GETPEERNAME = (long)205L;
        public static readonly long SYS_SENDTO = (long)206L;
        public static readonly long SYS_RECVFROM = (long)207L;
        public static readonly long SYS_SETSOCKOPT = (long)208L;
        public static readonly long SYS_GETSOCKOPT = (long)209L;
        public static readonly long SYS_SHUTDOWN = (long)210L;
        public static readonly long SYS_SENDMSG = (long)211L;
        public static readonly long SYS_RECVMSG = (long)212L;
        public static readonly long SYS_READAHEAD = (long)213L;
        public static readonly long SYS_BRK = (long)214L;
        public static readonly long SYS_MUNMAP = (long)215L;
        public static readonly long SYS_MREMAP = (long)216L;
        public static readonly long SYS_ADD_KEY = (long)217L;
        public static readonly long SYS_REQUEST_KEY = (long)218L;
        public static readonly long SYS_KEYCTL = (long)219L;
        public static readonly long SYS_CLONE = (long)220L;
        public static readonly long SYS_EXECVE = (long)221L;
        public static readonly long SYS_MMAP = (long)222L;
        public static readonly long SYS_FADVISE64 = (long)223L;
        public static readonly long SYS_SWAPON = (long)224L;
        public static readonly long SYS_SWAPOFF = (long)225L;
        public static readonly long SYS_MPROTECT = (long)226L;
        public static readonly long SYS_MSYNC = (long)227L;
        public static readonly long SYS_MLOCK = (long)228L;
        public static readonly long SYS_MUNLOCK = (long)229L;
        public static readonly long SYS_MLOCKALL = (long)230L;
        public static readonly long SYS_MUNLOCKALL = (long)231L;
        public static readonly long SYS_MINCORE = (long)232L;
        public static readonly long SYS_MADVISE = (long)233L;
        public static readonly long SYS_REMAP_FILE_PAGES = (long)234L;
        public static readonly long SYS_MBIND = (long)235L;
        public static readonly long SYS_GET_MEMPOLICY = (long)236L;
        public static readonly long SYS_SET_MEMPOLICY = (long)237L;
        public static readonly long SYS_MIGRATE_PAGES = (long)238L;
        public static readonly long SYS_MOVE_PAGES = (long)239L;
        public static readonly long SYS_RT_TGSIGQUEUEINFO = (long)240L;
        public static readonly long SYS_PERF_EVENT_OPEN = (long)241L;
        public static readonly long SYS_ACCEPT4 = (long)242L;
        public static readonly long SYS_RECVMMSG = (long)243L;
        public static readonly long SYS_ARCH_SPECIFIC_SYSCALL = (long)244L;
        public static readonly long SYS_WAIT4 = (long)260L;
        public static readonly long SYS_PRLIMIT64 = (long)261L;
        public static readonly long SYS_FANOTIFY_INIT = (long)262L;
        public static readonly long SYS_FANOTIFY_MARK = (long)263L;
        public static readonly long SYS_NAME_TO_HANDLE_AT = (long)264L;
        public static readonly long SYS_OPEN_BY_HANDLE_AT = (long)265L;
        public static readonly long SYS_CLOCK_ADJTIME = (long)266L;
        public static readonly long SYS_SYNCFS = (long)267L;
        public static readonly long SYS_SETNS = (long)268L;
        public static readonly long SYS_SENDMMSG = (long)269L;
        public static readonly long SYS_PROCESS_VM_READV = (long)270L;
        public static readonly long SYS_PROCESS_VM_WRITEV = (long)271L;
        public static readonly long SYS_KCMP = (long)272L;
        public static readonly long SYS_FINIT_MODULE = (long)273L;
        public static readonly long SYS_SCHED_SETATTR = (long)274L;
        public static readonly long SYS_SCHED_GETATTR = (long)275L;
        public static readonly long SYS_RENAMEAT2 = (long)276L;
        public static readonly long SYS_SECCOMP = (long)277L;
        public static readonly long SYS_GETRANDOM = (long)278L;
        public static readonly long SYS_MEMFD_CREATE = (long)279L;
        public static readonly long SYS_BPF = (long)280L;
        public static readonly long SYS_EXECVEAT = (long)281L;
        public static readonly long SYS_USERFAULTFD = (long)282L;
        public static readonly long SYS_MEMBARRIER = (long)283L;
        public static readonly long SYS_MLOCK2 = (long)284L;
        public static readonly long SYS_COPY_FILE_RANGE = (long)285L;
        public static readonly long SYS_PREADV2 = (long)286L;
        public static readonly long SYS_PWRITEV2 = (long)287L;
        public static readonly long SYS_PKEY_MPROTECT = (long)288L;
        public static readonly long SYS_PKEY_ALLOC = (long)289L;
        public static readonly long SYS_PKEY_FREE = (long)290L;
        public static readonly long SYS_STATX = (long)291L;
        public static readonly long SYS_IO_PGETEVENTS = (long)292L;
        public static readonly long SYS_RSEQ = (long)293L;
        public static readonly long SYS_KEXEC_FILE_LOAD = (long)294L;
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
