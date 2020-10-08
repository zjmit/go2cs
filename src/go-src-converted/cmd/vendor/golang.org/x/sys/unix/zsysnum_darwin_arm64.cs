// go run mksysnum.go /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS11.1.sdk/usr/include/sys/syscall.h
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build arm64,darwin

// package unix -- go2cs converted at 2020 October 08 04:53:24 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zsysnum_darwin_arm64.go

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
        public static readonly long SYS_SYSCALL = (long)0L;
        public static readonly long SYS_EXIT = (long)1L;
        public static readonly long SYS_FORK = (long)2L;
        public static readonly long SYS_READ = (long)3L;
        public static readonly long SYS_WRITE = (long)4L;
        public static readonly long SYS_OPEN = (long)5L;
        public static readonly long SYS_CLOSE = (long)6L;
        public static readonly long SYS_WAIT4 = (long)7L;
        public static readonly long SYS_LINK = (long)9L;
        public static readonly long SYS_UNLINK = (long)10L;
        public static readonly long SYS_CHDIR = (long)12L;
        public static readonly long SYS_FCHDIR = (long)13L;
        public static readonly long SYS_MKNOD = (long)14L;
        public static readonly long SYS_CHMOD = (long)15L;
        public static readonly long SYS_CHOWN = (long)16L;
        public static readonly long SYS_GETFSSTAT = (long)18L;
        public static readonly long SYS_GETPID = (long)20L;
        public static readonly long SYS_SETUID = (long)23L;
        public static readonly long SYS_GETUID = (long)24L;
        public static readonly long SYS_GETEUID = (long)25L;
        public static readonly long SYS_PTRACE = (long)26L;
        public static readonly long SYS_RECVMSG = (long)27L;
        public static readonly long SYS_SENDMSG = (long)28L;
        public static readonly long SYS_RECVFROM = (long)29L;
        public static readonly long SYS_ACCEPT = (long)30L;
        public static readonly long SYS_GETPEERNAME = (long)31L;
        public static readonly long SYS_GETSOCKNAME = (long)32L;
        public static readonly long SYS_ACCESS = (long)33L;
        public static readonly long SYS_CHFLAGS = (long)34L;
        public static readonly long SYS_FCHFLAGS = (long)35L;
        public static readonly long SYS_SYNC = (long)36L;
        public static readonly long SYS_KILL = (long)37L;
        public static readonly long SYS_GETPPID = (long)39L;
        public static readonly long SYS_DUP = (long)41L;
        public static readonly long SYS_PIPE = (long)42L;
        public static readonly long SYS_GETEGID = (long)43L;
        public static readonly long SYS_SIGACTION = (long)46L;
        public static readonly long SYS_GETGID = (long)47L;
        public static readonly long SYS_SIGPROCMASK = (long)48L;
        public static readonly long SYS_GETLOGIN = (long)49L;
        public static readonly long SYS_SETLOGIN = (long)50L;
        public static readonly long SYS_ACCT = (long)51L;
        public static readonly long SYS_SIGPENDING = (long)52L;
        public static readonly long SYS_SIGALTSTACK = (long)53L;
        public static readonly long SYS_IOCTL = (long)54L;
        public static readonly long SYS_REBOOT = (long)55L;
        public static readonly long SYS_REVOKE = (long)56L;
        public static readonly long SYS_SYMLINK = (long)57L;
        public static readonly long SYS_READLINK = (long)58L;
        public static readonly long SYS_EXECVE = (long)59L;
        public static readonly long SYS_UMASK = (long)60L;
        public static readonly long SYS_CHROOT = (long)61L;
        public static readonly long SYS_MSYNC = (long)65L;
        public static readonly long SYS_VFORK = (long)66L;
        public static readonly long SYS_MUNMAP = (long)73L;
        public static readonly long SYS_MPROTECT = (long)74L;
        public static readonly long SYS_MADVISE = (long)75L;
        public static readonly long SYS_MINCORE = (long)78L;
        public static readonly long SYS_GETGROUPS = (long)79L;
        public static readonly long SYS_SETGROUPS = (long)80L;
        public static readonly long SYS_GETPGRP = (long)81L;
        public static readonly long SYS_SETPGID = (long)82L;
        public static readonly long SYS_SETITIMER = (long)83L;
        public static readonly long SYS_SWAPON = (long)85L;
        public static readonly long SYS_GETITIMER = (long)86L;
        public static readonly long SYS_GETDTABLESIZE = (long)89L;
        public static readonly long SYS_DUP2 = (long)90L;
        public static readonly long SYS_FCNTL = (long)92L;
        public static readonly long SYS_SELECT = (long)93L;
        public static readonly long SYS_FSYNC = (long)95L;
        public static readonly long SYS_SETPRIORITY = (long)96L;
        public static readonly long SYS_SOCKET = (long)97L;
        public static readonly long SYS_CONNECT = (long)98L;
        public static readonly long SYS_GETPRIORITY = (long)100L;
        public static readonly long SYS_BIND = (long)104L;
        public static readonly long SYS_SETSOCKOPT = (long)105L;
        public static readonly long SYS_LISTEN = (long)106L;
        public static readonly long SYS_SIGSUSPEND = (long)111L;
        public static readonly long SYS_GETTIMEOFDAY = (long)116L;
        public static readonly long SYS_GETRUSAGE = (long)117L;
        public static readonly long SYS_GETSOCKOPT = (long)118L;
        public static readonly long SYS_READV = (long)120L;
        public static readonly long SYS_WRITEV = (long)121L;
        public static readonly long SYS_SETTIMEOFDAY = (long)122L;
        public static readonly long SYS_FCHOWN = (long)123L;
        public static readonly long SYS_FCHMOD = (long)124L;
        public static readonly long SYS_SETREUID = (long)126L;
        public static readonly long SYS_SETREGID = (long)127L;
        public static readonly long SYS_RENAME = (long)128L;
        public static readonly long SYS_FLOCK = (long)131L;
        public static readonly long SYS_MKFIFO = (long)132L;
        public static readonly long SYS_SENDTO = (long)133L;
        public static readonly long SYS_SHUTDOWN = (long)134L;
        public static readonly long SYS_SOCKETPAIR = (long)135L;
        public static readonly long SYS_MKDIR = (long)136L;
        public static readonly long SYS_RMDIR = (long)137L;
        public static readonly long SYS_UTIMES = (long)138L;
        public static readonly long SYS_FUTIMES = (long)139L;
        public static readonly long SYS_ADJTIME = (long)140L;
        public static readonly long SYS_GETHOSTUUID = (long)142L;
        public static readonly long SYS_SETSID = (long)147L;
        public static readonly long SYS_GETPGID = (long)151L;
        public static readonly long SYS_SETPRIVEXEC = (long)152L;
        public static readonly long SYS_PREAD = (long)153L;
        public static readonly long SYS_PWRITE = (long)154L;
        public static readonly long SYS_NFSSVC = (long)155L;
        public static readonly long SYS_STATFS = (long)157L;
        public static readonly long SYS_FSTATFS = (long)158L;
        public static readonly long SYS_UNMOUNT = (long)159L;
        public static readonly long SYS_GETFH = (long)161L;
        public static readonly long SYS_QUOTACTL = (long)165L;
        public static readonly long SYS_MOUNT = (long)167L;
        public static readonly long SYS_CSOPS = (long)169L;
        public static readonly long SYS_CSOPS_AUDITTOKEN = (long)170L;
        public static readonly long SYS_WAITID = (long)173L;
        public static readonly long SYS_KDEBUG_TYPEFILTER = (long)177L;
        public static readonly long SYS_KDEBUG_TRACE_STRING = (long)178L;
        public static readonly long SYS_KDEBUG_TRACE64 = (long)179L;
        public static readonly long SYS_KDEBUG_TRACE = (long)180L;
        public static readonly long SYS_SETGID = (long)181L;
        public static readonly long SYS_SETEGID = (long)182L;
        public static readonly long SYS_SETEUID = (long)183L;
        public static readonly long SYS_SIGRETURN = (long)184L;
        public static readonly long SYS_THREAD_SELFCOUNTS = (long)186L;
        public static readonly long SYS_FDATASYNC = (long)187L;
        public static readonly long SYS_STAT = (long)188L;
        public static readonly long SYS_FSTAT = (long)189L;
        public static readonly long SYS_LSTAT = (long)190L;
        public static readonly long SYS_PATHCONF = (long)191L;
        public static readonly long SYS_FPATHCONF = (long)192L;
        public static readonly long SYS_GETRLIMIT = (long)194L;
        public static readonly long SYS_SETRLIMIT = (long)195L;
        public static readonly long SYS_GETDIRENTRIES = (long)196L;
        public static readonly long SYS_MMAP = (long)197L;
        public static readonly long SYS_LSEEK = (long)199L;
        public static readonly long SYS_TRUNCATE = (long)200L;
        public static readonly long SYS_FTRUNCATE = (long)201L;
        public static readonly long SYS_SYSCTL = (long)202L;
        public static readonly long SYS_MLOCK = (long)203L;
        public static readonly long SYS_MUNLOCK = (long)204L;
        public static readonly long SYS_UNDELETE = (long)205L;
        public static readonly long SYS_OPEN_DPROTECTED_NP = (long)216L;
        public static readonly long SYS_GETATTRLIST = (long)220L;
        public static readonly long SYS_SETATTRLIST = (long)221L;
        public static readonly long SYS_GETDIRENTRIESATTR = (long)222L;
        public static readonly long SYS_EXCHANGEDATA = (long)223L;
        public static readonly long SYS_SEARCHFS = (long)225L;
        public static readonly long SYS_DELETE = (long)226L;
        public static readonly long SYS_COPYFILE = (long)227L;
        public static readonly long SYS_FGETATTRLIST = (long)228L;
        public static readonly long SYS_FSETATTRLIST = (long)229L;
        public static readonly long SYS_POLL = (long)230L;
        public static readonly long SYS_WATCHEVENT = (long)231L;
        public static readonly long SYS_WAITEVENT = (long)232L;
        public static readonly long SYS_MODWATCH = (long)233L;
        public static readonly long SYS_GETXATTR = (long)234L;
        public static readonly long SYS_FGETXATTR = (long)235L;
        public static readonly long SYS_SETXATTR = (long)236L;
        public static readonly long SYS_FSETXATTR = (long)237L;
        public static readonly long SYS_REMOVEXATTR = (long)238L;
        public static readonly long SYS_FREMOVEXATTR = (long)239L;
        public static readonly long SYS_LISTXATTR = (long)240L;
        public static readonly long SYS_FLISTXATTR = (long)241L;
        public static readonly long SYS_FSCTL = (long)242L;
        public static readonly long SYS_INITGROUPS = (long)243L;
        public static readonly long SYS_POSIX_SPAWN = (long)244L;
        public static readonly long SYS_FFSCTL = (long)245L;
        public static readonly long SYS_NFSCLNT = (long)247L;
        public static readonly long SYS_FHOPEN = (long)248L;
        public static readonly long SYS_MINHERIT = (long)250L;
        public static readonly long SYS_SEMSYS = (long)251L;
        public static readonly long SYS_MSGSYS = (long)252L;
        public static readonly long SYS_SHMSYS = (long)253L;
        public static readonly long SYS_SEMCTL = (long)254L;
        public static readonly long SYS_SEMGET = (long)255L;
        public static readonly long SYS_SEMOP = (long)256L;
        public static readonly long SYS_MSGCTL = (long)258L;
        public static readonly long SYS_MSGGET = (long)259L;
        public static readonly long SYS_MSGSND = (long)260L;
        public static readonly long SYS_MSGRCV = (long)261L;
        public static readonly long SYS_SHMAT = (long)262L;
        public static readonly long SYS_SHMCTL = (long)263L;
        public static readonly long SYS_SHMDT = (long)264L;
        public static readonly long SYS_SHMGET = (long)265L;
        public static readonly long SYS_SHM_OPEN = (long)266L;
        public static readonly long SYS_SHM_UNLINK = (long)267L;
        public static readonly long SYS_SEM_OPEN = (long)268L;
        public static readonly long SYS_SEM_CLOSE = (long)269L;
        public static readonly long SYS_SEM_UNLINK = (long)270L;
        public static readonly long SYS_SEM_WAIT = (long)271L;
        public static readonly long SYS_SEM_TRYWAIT = (long)272L;
        public static readonly long SYS_SEM_POST = (long)273L;
        public static readonly long SYS_SYSCTLBYNAME = (long)274L;
        public static readonly long SYS_OPEN_EXTENDED = (long)277L;
        public static readonly long SYS_UMASK_EXTENDED = (long)278L;
        public static readonly long SYS_STAT_EXTENDED = (long)279L;
        public static readonly long SYS_LSTAT_EXTENDED = (long)280L;
        public static readonly long SYS_FSTAT_EXTENDED = (long)281L;
        public static readonly long SYS_CHMOD_EXTENDED = (long)282L;
        public static readonly long SYS_FCHMOD_EXTENDED = (long)283L;
        public static readonly long SYS_ACCESS_EXTENDED = (long)284L;
        public static readonly long SYS_SETTID = (long)285L;
        public static readonly long SYS_GETTID = (long)286L;
        public static readonly long SYS_SETSGROUPS = (long)287L;
        public static readonly long SYS_GETSGROUPS = (long)288L;
        public static readonly long SYS_SETWGROUPS = (long)289L;
        public static readonly long SYS_GETWGROUPS = (long)290L;
        public static readonly long SYS_MKFIFO_EXTENDED = (long)291L;
        public static readonly long SYS_MKDIR_EXTENDED = (long)292L;
        public static readonly long SYS_IDENTITYSVC = (long)293L;
        public static readonly long SYS_SHARED_REGION_CHECK_NP = (long)294L;
        public static readonly long SYS_VM_PRESSURE_MONITOR = (long)296L;
        public static readonly long SYS_PSYNCH_RW_LONGRDLOCK = (long)297L;
        public static readonly long SYS_PSYNCH_RW_YIELDWRLOCK = (long)298L;
        public static readonly long SYS_PSYNCH_RW_DOWNGRADE = (long)299L;
        public static readonly long SYS_PSYNCH_RW_UPGRADE = (long)300L;
        public static readonly long SYS_PSYNCH_MUTEXWAIT = (long)301L;
        public static readonly long SYS_PSYNCH_MUTEXDROP = (long)302L;
        public static readonly long SYS_PSYNCH_CVBROAD = (long)303L;
        public static readonly long SYS_PSYNCH_CVSIGNAL = (long)304L;
        public static readonly long SYS_PSYNCH_CVWAIT = (long)305L;
        public static readonly long SYS_PSYNCH_RW_RDLOCK = (long)306L;
        public static readonly long SYS_PSYNCH_RW_WRLOCK = (long)307L;
        public static readonly long SYS_PSYNCH_RW_UNLOCK = (long)308L;
        public static readonly long SYS_PSYNCH_RW_UNLOCK2 = (long)309L;
        public static readonly long SYS_GETSID = (long)310L;
        public static readonly long SYS_SETTID_WITH_PID = (long)311L;
        public static readonly long SYS_PSYNCH_CVCLRPREPOST = (long)312L;
        public static readonly long SYS_AIO_FSYNC = (long)313L;
        public static readonly long SYS_AIO_RETURN = (long)314L;
        public static readonly long SYS_AIO_SUSPEND = (long)315L;
        public static readonly long SYS_AIO_CANCEL = (long)316L;
        public static readonly long SYS_AIO_ERROR = (long)317L;
        public static readonly long SYS_AIO_READ = (long)318L;
        public static readonly long SYS_AIO_WRITE = (long)319L;
        public static readonly long SYS_LIO_LISTIO = (long)320L;
        public static readonly long SYS_IOPOLICYSYS = (long)322L;
        public static readonly long SYS_PROCESS_POLICY = (long)323L;
        public static readonly long SYS_MLOCKALL = (long)324L;
        public static readonly long SYS_MUNLOCKALL = (long)325L;
        public static readonly long SYS_ISSETUGID = (long)327L;
        public static readonly long SYS___PTHREAD_KILL = (long)328L;
        public static readonly long SYS___PTHREAD_SIGMASK = (long)329L;
        public static readonly long SYS___SIGWAIT = (long)330L;
        public static readonly long SYS___DISABLE_THREADSIGNAL = (long)331L;
        public static readonly long SYS___PTHREAD_MARKCANCEL = (long)332L;
        public static readonly long SYS___PTHREAD_CANCELED = (long)333L;
        public static readonly long SYS___SEMWAIT_SIGNAL = (long)334L;
        public static readonly long SYS_PROC_INFO = (long)336L;
        public static readonly long SYS_SENDFILE = (long)337L;
        public static readonly long SYS_STAT64 = (long)338L;
        public static readonly long SYS_FSTAT64 = (long)339L;
        public static readonly long SYS_LSTAT64 = (long)340L;
        public static readonly long SYS_STAT64_EXTENDED = (long)341L;
        public static readonly long SYS_LSTAT64_EXTENDED = (long)342L;
        public static readonly long SYS_FSTAT64_EXTENDED = (long)343L;
        public static readonly long SYS_GETDIRENTRIES64 = (long)344L;
        public static readonly long SYS_STATFS64 = (long)345L;
        public static readonly long SYS_FSTATFS64 = (long)346L;
        public static readonly long SYS_GETFSSTAT64 = (long)347L;
        public static readonly long SYS___PTHREAD_CHDIR = (long)348L;
        public static readonly long SYS___PTHREAD_FCHDIR = (long)349L;
        public static readonly long SYS_AUDIT = (long)350L;
        public static readonly long SYS_AUDITON = (long)351L;
        public static readonly long SYS_GETAUID = (long)353L;
        public static readonly long SYS_SETAUID = (long)354L;
        public static readonly long SYS_GETAUDIT_ADDR = (long)357L;
        public static readonly long SYS_SETAUDIT_ADDR = (long)358L;
        public static readonly long SYS_AUDITCTL = (long)359L;
        public static readonly long SYS_BSDTHREAD_CREATE = (long)360L;
        public static readonly long SYS_BSDTHREAD_TERMINATE = (long)361L;
        public static readonly long SYS_KQUEUE = (long)362L;
        public static readonly long SYS_KEVENT = (long)363L;
        public static readonly long SYS_LCHOWN = (long)364L;
        public static readonly long SYS_BSDTHREAD_REGISTER = (long)366L;
        public static readonly long SYS_WORKQ_OPEN = (long)367L;
        public static readonly long SYS_WORKQ_KERNRETURN = (long)368L;
        public static readonly long SYS_KEVENT64 = (long)369L;
        public static readonly long SYS___OLD_SEMWAIT_SIGNAL = (long)370L;
        public static readonly long SYS___OLD_SEMWAIT_SIGNAL_NOCANCEL = (long)371L;
        public static readonly long SYS_THREAD_SELFID = (long)372L;
        public static readonly long SYS_LEDGER = (long)373L;
        public static readonly long SYS_KEVENT_QOS = (long)374L;
        public static readonly long SYS_KEVENT_ID = (long)375L;
        public static readonly long SYS___MAC_EXECVE = (long)380L;
        public static readonly long SYS___MAC_SYSCALL = (long)381L;
        public static readonly long SYS___MAC_GET_FILE = (long)382L;
        public static readonly long SYS___MAC_SET_FILE = (long)383L;
        public static readonly long SYS___MAC_GET_LINK = (long)384L;
        public static readonly long SYS___MAC_SET_LINK = (long)385L;
        public static readonly long SYS___MAC_GET_PROC = (long)386L;
        public static readonly long SYS___MAC_SET_PROC = (long)387L;
        public static readonly long SYS___MAC_GET_FD = (long)388L;
        public static readonly long SYS___MAC_SET_FD = (long)389L;
        public static readonly long SYS___MAC_GET_PID = (long)390L;
        public static readonly long SYS_PSELECT = (long)394L;
        public static readonly long SYS_PSELECT_NOCANCEL = (long)395L;
        public static readonly long SYS_READ_NOCANCEL = (long)396L;
        public static readonly long SYS_WRITE_NOCANCEL = (long)397L;
        public static readonly long SYS_OPEN_NOCANCEL = (long)398L;
        public static readonly long SYS_CLOSE_NOCANCEL = (long)399L;
        public static readonly long SYS_WAIT4_NOCANCEL = (long)400L;
        public static readonly long SYS_RECVMSG_NOCANCEL = (long)401L;
        public static readonly long SYS_SENDMSG_NOCANCEL = (long)402L;
        public static readonly long SYS_RECVFROM_NOCANCEL = (long)403L;
        public static readonly long SYS_ACCEPT_NOCANCEL = (long)404L;
        public static readonly long SYS_MSYNC_NOCANCEL = (long)405L;
        public static readonly long SYS_FCNTL_NOCANCEL = (long)406L;
        public static readonly long SYS_SELECT_NOCANCEL = (long)407L;
        public static readonly long SYS_FSYNC_NOCANCEL = (long)408L;
        public static readonly long SYS_CONNECT_NOCANCEL = (long)409L;
        public static readonly long SYS_SIGSUSPEND_NOCANCEL = (long)410L;
        public static readonly long SYS_READV_NOCANCEL = (long)411L;
        public static readonly long SYS_WRITEV_NOCANCEL = (long)412L;
        public static readonly long SYS_SENDTO_NOCANCEL = (long)413L;
        public static readonly long SYS_PREAD_NOCANCEL = (long)414L;
        public static readonly long SYS_PWRITE_NOCANCEL = (long)415L;
        public static readonly long SYS_WAITID_NOCANCEL = (long)416L;
        public static readonly long SYS_POLL_NOCANCEL = (long)417L;
        public static readonly long SYS_MSGSND_NOCANCEL = (long)418L;
        public static readonly long SYS_MSGRCV_NOCANCEL = (long)419L;
        public static readonly long SYS_SEM_WAIT_NOCANCEL = (long)420L;
        public static readonly long SYS_AIO_SUSPEND_NOCANCEL = (long)421L;
        public static readonly long SYS___SIGWAIT_NOCANCEL = (long)422L;
        public static readonly long SYS___SEMWAIT_SIGNAL_NOCANCEL = (long)423L;
        public static readonly long SYS___MAC_MOUNT = (long)424L;
        public static readonly long SYS___MAC_GET_MOUNT = (long)425L;
        public static readonly long SYS___MAC_GETFSSTAT = (long)426L;
        public static readonly long SYS_FSGETPATH = (long)427L;
        public static readonly long SYS_AUDIT_SESSION_SELF = (long)428L;
        public static readonly long SYS_AUDIT_SESSION_JOIN = (long)429L;
        public static readonly long SYS_FILEPORT_MAKEPORT = (long)430L;
        public static readonly long SYS_FILEPORT_MAKEFD = (long)431L;
        public static readonly long SYS_AUDIT_SESSION_PORT = (long)432L;
        public static readonly long SYS_PID_SUSPEND = (long)433L;
        public static readonly long SYS_PID_RESUME = (long)434L;
        public static readonly long SYS_PID_HIBERNATE = (long)435L;
        public static readonly long SYS_PID_SHUTDOWN_SOCKETS = (long)436L;
        public static readonly long SYS_SHARED_REGION_MAP_AND_SLIDE_NP = (long)438L;
        public static readonly long SYS_KAS_INFO = (long)439L;
        public static readonly long SYS_MEMORYSTATUS_CONTROL = (long)440L;
        public static readonly long SYS_GUARDED_OPEN_NP = (long)441L;
        public static readonly long SYS_GUARDED_CLOSE_NP = (long)442L;
        public static readonly long SYS_GUARDED_KQUEUE_NP = (long)443L;
        public static readonly long SYS_CHANGE_FDGUARD_NP = (long)444L;
        public static readonly long SYS_USRCTL = (long)445L;
        public static readonly long SYS_PROC_RLIMIT_CONTROL = (long)446L;
        public static readonly long SYS_CONNECTX = (long)447L;
        public static readonly long SYS_DISCONNECTX = (long)448L;
        public static readonly long SYS_PEELOFF = (long)449L;
        public static readonly long SYS_SOCKET_DELEGATE = (long)450L;
        public static readonly long SYS_TELEMETRY = (long)451L;
        public static readonly long SYS_PROC_UUID_POLICY = (long)452L;
        public static readonly long SYS_MEMORYSTATUS_GET_LEVEL = (long)453L;
        public static readonly long SYS_SYSTEM_OVERRIDE = (long)454L;
        public static readonly long SYS_VFS_PURGE = (long)455L;
        public static readonly long SYS_SFI_CTL = (long)456L;
        public static readonly long SYS_SFI_PIDCTL = (long)457L;
        public static readonly long SYS_COALITION = (long)458L;
        public static readonly long SYS_COALITION_INFO = (long)459L;
        public static readonly long SYS_NECP_MATCH_POLICY = (long)460L;
        public static readonly long SYS_GETATTRLISTBULK = (long)461L;
        public static readonly long SYS_CLONEFILEAT = (long)462L;
        public static readonly long SYS_OPENAT = (long)463L;
        public static readonly long SYS_OPENAT_NOCANCEL = (long)464L;
        public static readonly long SYS_RENAMEAT = (long)465L;
        public static readonly long SYS_FACCESSAT = (long)466L;
        public static readonly long SYS_FCHMODAT = (long)467L;
        public static readonly long SYS_FCHOWNAT = (long)468L;
        public static readonly long SYS_FSTATAT = (long)469L;
        public static readonly long SYS_FSTATAT64 = (long)470L;
        public static readonly long SYS_LINKAT = (long)471L;
        public static readonly long SYS_UNLINKAT = (long)472L;
        public static readonly long SYS_READLINKAT = (long)473L;
        public static readonly long SYS_SYMLINKAT = (long)474L;
        public static readonly long SYS_MKDIRAT = (long)475L;
        public static readonly long SYS_GETATTRLISTAT = (long)476L;
        public static readonly long SYS_PROC_TRACE_LOG = (long)477L;
        public static readonly long SYS_BSDTHREAD_CTL = (long)478L;
        public static readonly long SYS_OPENBYID_NP = (long)479L;
        public static readonly long SYS_RECVMSG_X = (long)480L;
        public static readonly long SYS_SENDMSG_X = (long)481L;
        public static readonly long SYS_THREAD_SELFUSAGE = (long)482L;
        public static readonly long SYS_CSRCTL = (long)483L;
        public static readonly long SYS_GUARDED_OPEN_DPROTECTED_NP = (long)484L;
        public static readonly long SYS_GUARDED_WRITE_NP = (long)485L;
        public static readonly long SYS_GUARDED_PWRITE_NP = (long)486L;
        public static readonly long SYS_GUARDED_WRITEV_NP = (long)487L;
        public static readonly long SYS_RENAMEATX_NP = (long)488L;
        public static readonly long SYS_MREMAP_ENCRYPTED = (long)489L;
        public static readonly long SYS_NETAGENT_TRIGGER = (long)490L;
        public static readonly long SYS_STACK_SNAPSHOT_WITH_CONFIG = (long)491L;
        public static readonly long SYS_MICROSTACKSHOT = (long)492L;
        public static readonly long SYS_GRAB_PGO_DATA = (long)493L;
        public static readonly long SYS_PERSONA = (long)494L;
        public static readonly long SYS_WORK_INTERVAL_CTL = (long)499L;
        public static readonly long SYS_GETENTROPY = (long)500L;
        public static readonly long SYS_NECP_OPEN = (long)501L;
        public static readonly long SYS_NECP_CLIENT_ACTION = (long)502L;
        public static readonly long SYS___NEXUS_OPEN = (long)503L;
        public static readonly long SYS___NEXUS_REGISTER = (long)504L;
        public static readonly long SYS___NEXUS_DEREGISTER = (long)505L;
        public static readonly long SYS___NEXUS_CREATE = (long)506L;
        public static readonly long SYS___NEXUS_DESTROY = (long)507L;
        public static readonly long SYS___NEXUS_GET_OPT = (long)508L;
        public static readonly long SYS___NEXUS_SET_OPT = (long)509L;
        public static readonly long SYS___CHANNEL_OPEN = (long)510L;
        public static readonly long SYS___CHANNEL_GET_INFO = (long)511L;
        public static readonly long SYS___CHANNEL_SYNC = (long)512L;
        public static readonly long SYS___CHANNEL_GET_OPT = (long)513L;
        public static readonly long SYS___CHANNEL_SET_OPT = (long)514L;
        public static readonly long SYS_ULOCK_WAIT = (long)515L;
        public static readonly long SYS_ULOCK_WAKE = (long)516L;
        public static readonly long SYS_FCLONEFILEAT = (long)517L;
        public static readonly long SYS_FS_SNAPSHOT = (long)518L;
        public static readonly long SYS_TERMINATE_WITH_PAYLOAD = (long)520L;
        public static readonly long SYS_ABORT_WITH_PAYLOAD = (long)521L;
        public static readonly long SYS_NECP_SESSION_OPEN = (long)522L;
        public static readonly long SYS_NECP_SESSION_ACTION = (long)523L;
        public static readonly long SYS_SETATTRLISTAT = (long)524L;
        public static readonly long SYS_NET_QOS_GUIDELINE = (long)525L;
        public static readonly long SYS_FMOUNT = (long)526L;
        public static readonly long SYS_NTP_ADJTIME = (long)527L;
        public static readonly long SYS_NTP_GETTIME = (long)528L;
        public static readonly long SYS_OS_FAULT_WITH_PAYLOAD = (long)529L;
        public static readonly long SYS_MAXSYSCALL = (long)530L;
        public static readonly long SYS_INVALID = (long)63L;

    }
}}}}}}
