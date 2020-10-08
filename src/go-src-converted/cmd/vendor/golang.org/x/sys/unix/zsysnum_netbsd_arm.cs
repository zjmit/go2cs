// go run mksysnum.go http://cvsweb.netbsd.org/bsdweb.cgi/~checkout~/src/sys/kern/syscalls.master
// Code generated by the command above; see README.md. DO NOT EDIT.

// +build arm,netbsd

// package unix -- go2cs converted at 2020 October 08 04:53:25 UTC
// import "cmd/vendor/golang.org/x/sys/unix" ==> using unix = go.cmd.vendor.golang.org.x.sys.unix_package
// Original source: C:\Go\src\cmd\vendor\golang.org\x\sys\unix\zsysnum_netbsd_arm.go

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
        public static readonly long SYS_EXIT = (long)1L; // { void|sys||exit(int rval); }
        public static readonly long SYS_FORK = (long)2L; // { int|sys||fork(void); }
        public static readonly long SYS_READ = (long)3L; // { ssize_t|sys||read(int fd, void *buf, size_t nbyte); }
        public static readonly long SYS_WRITE = (long)4L; // { ssize_t|sys||write(int fd, const void *buf, size_t nbyte); }
        public static readonly long SYS_OPEN = (long)5L; // { int|sys||open(const char *path, int flags, ... mode_t mode); }
        public static readonly long SYS_CLOSE = (long)6L; // { int|sys||close(int fd); }
        public static readonly long SYS_LINK = (long)9L; // { int|sys||link(const char *path, const char *link); }
        public static readonly long SYS_UNLINK = (long)10L; // { int|sys||unlink(const char *path); }
        public static readonly long SYS_CHDIR = (long)12L; // { int|sys||chdir(const char *path); }
        public static readonly long SYS_FCHDIR = (long)13L; // { int|sys||fchdir(int fd); }
        public static readonly long SYS_CHMOD = (long)15L; // { int|sys||chmod(const char *path, mode_t mode); }
        public static readonly long SYS_CHOWN = (long)16L; // { int|sys||chown(const char *path, uid_t uid, gid_t gid); }
        public static readonly long SYS_BREAK = (long)17L; // { int|sys||obreak(char *nsize); }
        public static readonly long SYS_GETPID = (long)20L; // { pid_t|sys||getpid_with_ppid(void); }
        public static readonly long SYS_UNMOUNT = (long)22L; // { int|sys||unmount(const char *path, int flags); }
        public static readonly long SYS_SETUID = (long)23L; // { int|sys||setuid(uid_t uid); }
        public static readonly long SYS_GETUID = (long)24L; // { uid_t|sys||getuid_with_euid(void); }
        public static readonly long SYS_GETEUID = (long)25L; // { uid_t|sys||geteuid(void); }
        public static readonly long SYS_PTRACE = (long)26L; // { int|sys||ptrace(int req, pid_t pid, void *addr, int data); }
        public static readonly long SYS_RECVMSG = (long)27L; // { ssize_t|sys||recvmsg(int s, struct msghdr *msg, int flags); }
        public static readonly long SYS_SENDMSG = (long)28L; // { ssize_t|sys||sendmsg(int s, const struct msghdr *msg, int flags); }
        public static readonly long SYS_RECVFROM = (long)29L; // { ssize_t|sys||recvfrom(int s, void *buf, size_t len, int flags, struct sockaddr *from, socklen_t *fromlenaddr); }
        public static readonly long SYS_ACCEPT = (long)30L; // { int|sys||accept(int s, struct sockaddr *name, socklen_t *anamelen); }
        public static readonly long SYS_GETPEERNAME = (long)31L; // { int|sys||getpeername(int fdes, struct sockaddr *asa, socklen_t *alen); }
        public static readonly long SYS_GETSOCKNAME = (long)32L; // { int|sys||getsockname(int fdes, struct sockaddr *asa, socklen_t *alen); }
        public static readonly long SYS_ACCESS = (long)33L; // { int|sys||access(const char *path, int flags); }
        public static readonly long SYS_CHFLAGS = (long)34L; // { int|sys||chflags(const char *path, u_long flags); }
        public static readonly long SYS_FCHFLAGS = (long)35L; // { int|sys||fchflags(int fd, u_long flags); }
        public static readonly long SYS_SYNC = (long)36L; // { void|sys||sync(void); }
        public static readonly long SYS_KILL = (long)37L; // { int|sys||kill(pid_t pid, int signum); }
        public static readonly long SYS_GETPPID = (long)39L; // { pid_t|sys||getppid(void); }
        public static readonly long SYS_DUP = (long)41L; // { int|sys||dup(int fd); }
        public static readonly long SYS_PIPE = (long)42L; // { int|sys||pipe(void); }
        public static readonly long SYS_GETEGID = (long)43L; // { gid_t|sys||getegid(void); }
        public static readonly long SYS_PROFIL = (long)44L; // { int|sys||profil(char *samples, size_t size, u_long offset, u_int scale); }
        public static readonly long SYS_KTRACE = (long)45L; // { int|sys||ktrace(const char *fname, int ops, int facs, pid_t pid); }
        public static readonly long SYS_GETGID = (long)47L; // { gid_t|sys||getgid_with_egid(void); }
        public static readonly long SYS___GETLOGIN = (long)49L; // { int|sys||__getlogin(char *namebuf, size_t namelen); }
        public static readonly long SYS___SETLOGIN = (long)50L; // { int|sys||__setlogin(const char *namebuf); }
        public static readonly long SYS_ACCT = (long)51L; // { int|sys||acct(const char *path); }
        public static readonly long SYS_IOCTL = (long)54L; // { int|sys||ioctl(int fd, u_long com, ... void *data); }
        public static readonly long SYS_REVOKE = (long)56L; // { int|sys||revoke(const char *path); }
        public static readonly long SYS_SYMLINK = (long)57L; // { int|sys||symlink(const char *path, const char *link); }
        public static readonly long SYS_READLINK = (long)58L; // { ssize_t|sys||readlink(const char *path, char *buf, size_t count); }
        public static readonly long SYS_EXECVE = (long)59L; // { int|sys||execve(const char *path, char * const *argp, char * const *envp); }
        public static readonly long SYS_UMASK = (long)60L; // { mode_t|sys||umask(mode_t newmask); }
        public static readonly long SYS_CHROOT = (long)61L; // { int|sys||chroot(const char *path); }
        public static readonly long SYS_VFORK = (long)66L; // { int|sys||vfork(void); }
        public static readonly long SYS_SBRK = (long)69L; // { int|sys||sbrk(intptr_t incr); }
        public static readonly long SYS_SSTK = (long)70L; // { int|sys||sstk(int incr); }
        public static readonly long SYS_VADVISE = (long)72L; // { int|sys||ovadvise(int anom); }
        public static readonly long SYS_MUNMAP = (long)73L; // { int|sys||munmap(void *addr, size_t len); }
        public static readonly long SYS_MPROTECT = (long)74L; // { int|sys||mprotect(void *addr, size_t len, int prot); }
        public static readonly long SYS_MADVISE = (long)75L; // { int|sys||madvise(void *addr, size_t len, int behav); }
        public static readonly long SYS_MINCORE = (long)78L; // { int|sys||mincore(void *addr, size_t len, char *vec); }
        public static readonly long SYS_GETGROUPS = (long)79L; // { int|sys||getgroups(int gidsetsize, gid_t *gidset); }
        public static readonly long SYS_SETGROUPS = (long)80L; // { int|sys||setgroups(int gidsetsize, const gid_t *gidset); }
        public static readonly long SYS_GETPGRP = (long)81L; // { int|sys||getpgrp(void); }
        public static readonly long SYS_SETPGID = (long)82L; // { int|sys||setpgid(pid_t pid, pid_t pgid); }
        public static readonly long SYS_DUP2 = (long)90L; // { int|sys||dup2(int from, int to); }
        public static readonly long SYS_FCNTL = (long)92L; // { int|sys||fcntl(int fd, int cmd, ... void *arg); }
        public static readonly long SYS_FSYNC = (long)95L; // { int|sys||fsync(int fd); }
        public static readonly long SYS_SETPRIORITY = (long)96L; // { int|sys||setpriority(int which, id_t who, int prio); }
        public static readonly long SYS_CONNECT = (long)98L; // { int|sys||connect(int s, const struct sockaddr *name, socklen_t namelen); }
        public static readonly long SYS_GETPRIORITY = (long)100L; // { int|sys||getpriority(int which, id_t who); }
        public static readonly long SYS_BIND = (long)104L; // { int|sys||bind(int s, const struct sockaddr *name, socklen_t namelen); }
        public static readonly long SYS_SETSOCKOPT = (long)105L; // { int|sys||setsockopt(int s, int level, int name, const void *val, socklen_t valsize); }
        public static readonly long SYS_LISTEN = (long)106L; // { int|sys||listen(int s, int backlog); }
        public static readonly long SYS_GETSOCKOPT = (long)118L; // { int|sys||getsockopt(int s, int level, int name, void *val, socklen_t *avalsize); }
        public static readonly long SYS_READV = (long)120L; // { ssize_t|sys||readv(int fd, const struct iovec *iovp, int iovcnt); }
        public static readonly long SYS_WRITEV = (long)121L; // { ssize_t|sys||writev(int fd, const struct iovec *iovp, int iovcnt); }
        public static readonly long SYS_FCHOWN = (long)123L; // { int|sys||fchown(int fd, uid_t uid, gid_t gid); }
        public static readonly long SYS_FCHMOD = (long)124L; // { int|sys||fchmod(int fd, mode_t mode); }
        public static readonly long SYS_SETREUID = (long)126L; // { int|sys||setreuid(uid_t ruid, uid_t euid); }
        public static readonly long SYS_SETREGID = (long)127L; // { int|sys||setregid(gid_t rgid, gid_t egid); }
        public static readonly long SYS_RENAME = (long)128L; // { int|sys||rename(const char *from, const char *to); }
        public static readonly long SYS_FLOCK = (long)131L; // { int|sys||flock(int fd, int how); }
        public static readonly long SYS_MKFIFO = (long)132L; // { int|sys||mkfifo(const char *path, mode_t mode); }
        public static readonly long SYS_SENDTO = (long)133L; // { ssize_t|sys||sendto(int s, const void *buf, size_t len, int flags, const struct sockaddr *to, socklen_t tolen); }
        public static readonly long SYS_SHUTDOWN = (long)134L; // { int|sys||shutdown(int s, int how); }
        public static readonly long SYS_SOCKETPAIR = (long)135L; // { int|sys||socketpair(int domain, int type, int protocol, int *rsv); }
        public static readonly long SYS_MKDIR = (long)136L; // { int|sys||mkdir(const char *path, mode_t mode); }
        public static readonly long SYS_RMDIR = (long)137L; // { int|sys||rmdir(const char *path); }
        public static readonly long SYS_SETSID = (long)147L; // { int|sys||setsid(void); }
        public static readonly long SYS_SYSARCH = (long)165L; // { int|sys||sysarch(int op, void *parms); }
        public static readonly long SYS_PREAD = (long)173L; // { ssize_t|sys||pread(int fd, void *buf, size_t nbyte, int PAD, off_t offset); }
        public static readonly long SYS_PWRITE = (long)174L; // { ssize_t|sys||pwrite(int fd, const void *buf, size_t nbyte, int PAD, off_t offset); }
        public static readonly long SYS_NTP_ADJTIME = (long)176L; // { int|sys||ntp_adjtime(struct timex *tp); }
        public static readonly long SYS_SETGID = (long)181L; // { int|sys||setgid(gid_t gid); }
        public static readonly long SYS_SETEGID = (long)182L; // { int|sys||setegid(gid_t egid); }
        public static readonly long SYS_SETEUID = (long)183L; // { int|sys||seteuid(uid_t euid); }
        public static readonly long SYS_PATHCONF = (long)191L; // { long|sys||pathconf(const char *path, int name); }
        public static readonly long SYS_FPATHCONF = (long)192L; // { long|sys||fpathconf(int fd, int name); }
        public static readonly long SYS_GETRLIMIT = (long)194L; // { int|sys||getrlimit(int which, struct rlimit *rlp); }
        public static readonly long SYS_SETRLIMIT = (long)195L; // { int|sys||setrlimit(int which, const struct rlimit *rlp); }
        public static readonly long SYS_MMAP = (long)197L; // { void *|sys||mmap(void *addr, size_t len, int prot, int flags, int fd, long PAD, off_t pos); }
        public static readonly long SYS_LSEEK = (long)199L; // { off_t|sys||lseek(int fd, int PAD, off_t offset, int whence); }
        public static readonly long SYS_TRUNCATE = (long)200L; // { int|sys||truncate(const char *path, int PAD, off_t length); }
        public static readonly long SYS_FTRUNCATE = (long)201L; // { int|sys||ftruncate(int fd, int PAD, off_t length); }
        public static readonly long SYS___SYSCTL = (long)202L; // { int|sys||__sysctl(const int *name, u_int namelen, void *old, size_t *oldlenp, const void *new, size_t newlen); }
        public static readonly long SYS_MLOCK = (long)203L; // { int|sys||mlock(const void *addr, size_t len); }
        public static readonly long SYS_MUNLOCK = (long)204L; // { int|sys||munlock(const void *addr, size_t len); }
        public static readonly long SYS_UNDELETE = (long)205L; // { int|sys||undelete(const char *path); }
        public static readonly long SYS_GETPGID = (long)207L; // { pid_t|sys||getpgid(pid_t pid); }
        public static readonly long SYS_REBOOT = (long)208L; // { int|sys||reboot(int opt, char *bootstr); }
        public static readonly long SYS_POLL = (long)209L; // { int|sys||poll(struct pollfd *fds, u_int nfds, int timeout); }
        public static readonly long SYS_SEMGET = (long)221L; // { int|sys||semget(key_t key, int nsems, int semflg); }
        public static readonly long SYS_SEMOP = (long)222L; // { int|sys||semop(int semid, struct sembuf *sops, size_t nsops); }
        public static readonly long SYS_SEMCONFIG = (long)223L; // { int|sys||semconfig(int flag); }
        public static readonly long SYS_MSGGET = (long)225L; // { int|sys||msgget(key_t key, int msgflg); }
        public static readonly long SYS_MSGSND = (long)226L; // { int|sys||msgsnd(int msqid, const void *msgp, size_t msgsz, int msgflg); }
        public static readonly long SYS_MSGRCV = (long)227L; // { ssize_t|sys||msgrcv(int msqid, void *msgp, size_t msgsz, long msgtyp, int msgflg); }
        public static readonly long SYS_SHMAT = (long)228L; // { void *|sys||shmat(int shmid, const void *shmaddr, int shmflg); }
        public static readonly long SYS_SHMDT = (long)230L; // { int|sys||shmdt(const void *shmaddr); }
        public static readonly long SYS_SHMGET = (long)231L; // { int|sys||shmget(key_t key, size_t size, int shmflg); }
        public static readonly long SYS_TIMER_CREATE = (long)235L; // { int|sys||timer_create(clockid_t clock_id, struct sigevent *evp, timer_t *timerid); }
        public static readonly long SYS_TIMER_DELETE = (long)236L; // { int|sys||timer_delete(timer_t timerid); }
        public static readonly long SYS_TIMER_GETOVERRUN = (long)239L; // { int|sys||timer_getoverrun(timer_t timerid); }
        public static readonly long SYS_FDATASYNC = (long)241L; // { int|sys||fdatasync(int fd); }
        public static readonly long SYS_MLOCKALL = (long)242L; // { int|sys||mlockall(int flags); }
        public static readonly long SYS_MUNLOCKALL = (long)243L; // { int|sys||munlockall(void); }
        public static readonly long SYS_SIGQUEUEINFO = (long)245L; // { int|sys||sigqueueinfo(pid_t pid, const siginfo_t *info); }
        public static readonly long SYS_MODCTL = (long)246L; // { int|sys||modctl(int cmd, void *arg); }
        public static readonly long SYS___POSIX_RENAME = (long)270L; // { int|sys||__posix_rename(const char *from, const char *to); }
        public static readonly long SYS_SWAPCTL = (long)271L; // { int|sys||swapctl(int cmd, void *arg, int misc); }
        public static readonly long SYS_MINHERIT = (long)273L; // { int|sys||minherit(void *addr, size_t len, int inherit); }
        public static readonly long SYS_LCHMOD = (long)274L; // { int|sys||lchmod(const char *path, mode_t mode); }
        public static readonly long SYS_LCHOWN = (long)275L; // { int|sys||lchown(const char *path, uid_t uid, gid_t gid); }
        public static readonly long SYS_MSYNC = (long)277L; // { int|sys|13|msync(void *addr, size_t len, int flags); }
        public static readonly long SYS___POSIX_CHOWN = (long)283L; // { int|sys||__posix_chown(const char *path, uid_t uid, gid_t gid); }
        public static readonly long SYS___POSIX_FCHOWN = (long)284L; // { int|sys||__posix_fchown(int fd, uid_t uid, gid_t gid); }
        public static readonly long SYS___POSIX_LCHOWN = (long)285L; // { int|sys||__posix_lchown(const char *path, uid_t uid, gid_t gid); }
        public static readonly long SYS_GETSID = (long)286L; // { pid_t|sys||getsid(pid_t pid); }
        public static readonly long SYS___CLONE = (long)287L; // { pid_t|sys||__clone(int flags, void *stack); }
        public static readonly long SYS_FKTRACE = (long)288L; // { int|sys||fktrace(int fd, int ops, int facs, pid_t pid); }
        public static readonly long SYS_PREADV = (long)289L; // { ssize_t|sys||preadv(int fd, const struct iovec *iovp, int iovcnt, int PAD, off_t offset); }
        public static readonly long SYS_PWRITEV = (long)290L; // { ssize_t|sys||pwritev(int fd, const struct iovec *iovp, int iovcnt, int PAD, off_t offset); }
        public static readonly long SYS___GETCWD = (long)296L; // { int|sys||__getcwd(char *bufp, size_t length); }
        public static readonly long SYS_FCHROOT = (long)297L; // { int|sys||fchroot(int fd); }
        public static readonly long SYS_LCHFLAGS = (long)304L; // { int|sys||lchflags(const char *path, u_long flags); }
        public static readonly long SYS_ISSETUGID = (long)305L; // { int|sys||issetugid(void); }
        public static readonly long SYS_UTRACE = (long)306L; // { int|sys||utrace(const char *label, void *addr, size_t len); }
        public static readonly long SYS_GETCONTEXT = (long)307L; // { int|sys||getcontext(struct __ucontext *ucp); }
        public static readonly long SYS_SETCONTEXT = (long)308L; // { int|sys||setcontext(const struct __ucontext *ucp); }
        public static readonly long SYS__LWP_CREATE = (long)309L; // { int|sys||_lwp_create(const struct __ucontext *ucp, u_long flags, lwpid_t *new_lwp); }
        public static readonly long SYS__LWP_EXIT = (long)310L; // { int|sys||_lwp_exit(void); }
        public static readonly long SYS__LWP_SELF = (long)311L; // { lwpid_t|sys||_lwp_self(void); }
        public static readonly long SYS__LWP_WAIT = (long)312L; // { int|sys||_lwp_wait(lwpid_t wait_for, lwpid_t *departed); }
        public static readonly long SYS__LWP_SUSPEND = (long)313L; // { int|sys||_lwp_suspend(lwpid_t target); }
        public static readonly long SYS__LWP_CONTINUE = (long)314L; // { int|sys||_lwp_continue(lwpid_t target); }
        public static readonly long SYS__LWP_WAKEUP = (long)315L; // { int|sys||_lwp_wakeup(lwpid_t target); }
        public static readonly long SYS__LWP_GETPRIVATE = (long)316L; // { void *|sys||_lwp_getprivate(void); }
        public static readonly long SYS__LWP_SETPRIVATE = (long)317L; // { void|sys||_lwp_setprivate(void *ptr); }
        public static readonly long SYS__LWP_KILL = (long)318L; // { int|sys||_lwp_kill(lwpid_t target, int signo); }
        public static readonly long SYS__LWP_DETACH = (long)319L; // { int|sys||_lwp_detach(lwpid_t target); }
        public static readonly long SYS__LWP_UNPARK = (long)321L; // { int|sys||_lwp_unpark(lwpid_t target, const void *hint); }
        public static readonly long SYS__LWP_UNPARK_ALL = (long)322L; // { ssize_t|sys||_lwp_unpark_all(const lwpid_t *targets, size_t ntargets, const void *hint); }
        public static readonly long SYS__LWP_SETNAME = (long)323L; // { int|sys||_lwp_setname(lwpid_t target, const char *name); }
        public static readonly long SYS__LWP_GETNAME = (long)324L; // { int|sys||_lwp_getname(lwpid_t target, char *name, size_t len); }
        public static readonly long SYS__LWP_CTL = (long)325L; // { int|sys||_lwp_ctl(int features, struct lwpctl **address); }
        public static readonly long SYS___SIGACTION_SIGTRAMP = (long)340L; // { int|sys||__sigaction_sigtramp(int signum, const struct sigaction *nsa, struct sigaction *osa, const void *tramp, int vers); }
        public static readonly long SYS_PMC_GET_INFO = (long)341L; // { int|sys||pmc_get_info(int ctr, int op, void *args); }
        public static readonly long SYS_PMC_CONTROL = (long)342L; // { int|sys||pmc_control(int ctr, int op, void *args); }
        public static readonly long SYS_RASCTL = (long)343L; // { int|sys||rasctl(void *addr, size_t len, int op); }
        public static readonly long SYS_KQUEUE = (long)344L; // { int|sys||kqueue(void); }
        public static readonly long SYS__SCHED_SETPARAM = (long)346L; // { int|sys||_sched_setparam(pid_t pid, lwpid_t lid, int policy, const struct sched_param *params); }
        public static readonly long SYS__SCHED_GETPARAM = (long)347L; // { int|sys||_sched_getparam(pid_t pid, lwpid_t lid, int *policy, struct sched_param *params); }
        public static readonly long SYS__SCHED_SETAFFINITY = (long)348L; // { int|sys||_sched_setaffinity(pid_t pid, lwpid_t lid, size_t size, const cpuset_t *cpuset); }
        public static readonly long SYS__SCHED_GETAFFINITY = (long)349L; // { int|sys||_sched_getaffinity(pid_t pid, lwpid_t lid, size_t size, cpuset_t *cpuset); }
        public static readonly long SYS_SCHED_YIELD = (long)350L; // { int|sys||sched_yield(void); }
        public static readonly long SYS_FSYNC_RANGE = (long)354L; // { int|sys||fsync_range(int fd, int flags, off_t start, off_t length); }
        public static readonly long SYS_UUIDGEN = (long)355L; // { int|sys||uuidgen(struct uuid *store, int count); }
        public static readonly long SYS_GETVFSSTAT = (long)356L; // { int|sys||getvfsstat(struct statvfs *buf, size_t bufsize, int flags); }
        public static readonly long SYS_STATVFS1 = (long)357L; // { int|sys||statvfs1(const char *path, struct statvfs *buf, int flags); }
        public static readonly long SYS_FSTATVFS1 = (long)358L; // { int|sys||fstatvfs1(int fd, struct statvfs *buf, int flags); }
        public static readonly long SYS_EXTATTRCTL = (long)360L; // { int|sys||extattrctl(const char *path, int cmd, const char *filename, int attrnamespace, const char *attrname); }
        public static readonly long SYS_EXTATTR_SET_FILE = (long)361L; // { int|sys||extattr_set_file(const char *path, int attrnamespace, const char *attrname, const void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_GET_FILE = (long)362L; // { ssize_t|sys||extattr_get_file(const char *path, int attrnamespace, const char *attrname, void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_DELETE_FILE = (long)363L; // { int|sys||extattr_delete_file(const char *path, int attrnamespace, const char *attrname); }
        public static readonly long SYS_EXTATTR_SET_FD = (long)364L; // { int|sys||extattr_set_fd(int fd, int attrnamespace, const char *attrname, const void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_GET_FD = (long)365L; // { ssize_t|sys||extattr_get_fd(int fd, int attrnamespace, const char *attrname, void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_DELETE_FD = (long)366L; // { int|sys||extattr_delete_fd(int fd, int attrnamespace, const char *attrname); }
        public static readonly long SYS_EXTATTR_SET_LINK = (long)367L; // { int|sys||extattr_set_link(const char *path, int attrnamespace, const char *attrname, const void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_GET_LINK = (long)368L; // { ssize_t|sys||extattr_get_link(const char *path, int attrnamespace, const char *attrname, void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_DELETE_LINK = (long)369L; // { int|sys||extattr_delete_link(const char *path, int attrnamespace, const char *attrname); }
        public static readonly long SYS_EXTATTR_LIST_FD = (long)370L; // { ssize_t|sys||extattr_list_fd(int fd, int attrnamespace, void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_LIST_FILE = (long)371L; // { ssize_t|sys||extattr_list_file(const char *path, int attrnamespace, void *data, size_t nbytes); }
        public static readonly long SYS_EXTATTR_LIST_LINK = (long)372L; // { ssize_t|sys||extattr_list_link(const char *path, int attrnamespace, void *data, size_t nbytes); }
        public static readonly long SYS_SETXATTR = (long)375L; // { int|sys||setxattr(const char *path, const char *name, const void *value, size_t size, int flags); }
        public static readonly long SYS_LSETXATTR = (long)376L; // { int|sys||lsetxattr(const char *path, const char *name, const void *value, size_t size, int flags); }
        public static readonly long SYS_FSETXATTR = (long)377L; // { int|sys||fsetxattr(int fd, const char *name, const void *value, size_t size, int flags); }
        public static readonly long SYS_GETXATTR = (long)378L; // { int|sys||getxattr(const char *path, const char *name, void *value, size_t size); }
        public static readonly long SYS_LGETXATTR = (long)379L; // { int|sys||lgetxattr(const char *path, const char *name, void *value, size_t size); }
        public static readonly long SYS_FGETXATTR = (long)380L; // { int|sys||fgetxattr(int fd, const char *name, void *value, size_t size); }
        public static readonly long SYS_LISTXATTR = (long)381L; // { int|sys||listxattr(const char *path, char *list, size_t size); }
        public static readonly long SYS_LLISTXATTR = (long)382L; // { int|sys||llistxattr(const char *path, char *list, size_t size); }
        public static readonly long SYS_FLISTXATTR = (long)383L; // { int|sys||flistxattr(int fd, char *list, size_t size); }
        public static readonly long SYS_REMOVEXATTR = (long)384L; // { int|sys||removexattr(const char *path, const char *name); }
        public static readonly long SYS_LREMOVEXATTR = (long)385L; // { int|sys||lremovexattr(const char *path, const char *name); }
        public static readonly long SYS_FREMOVEXATTR = (long)386L; // { int|sys||fremovexattr(int fd, const char *name); }
        public static readonly long SYS_GETDENTS = (long)390L; // { int|sys|30|getdents(int fd, char *buf, size_t count); }
        public static readonly long SYS_SOCKET = (long)394L; // { int|sys|30|socket(int domain, int type, int protocol); }
        public static readonly long SYS_GETFH = (long)395L; // { int|sys|30|getfh(const char *fname, void *fhp, size_t *fh_size); }
        public static readonly long SYS_MOUNT = (long)410L; // { int|sys|50|mount(const char *type, const char *path, int flags, void *data, size_t data_len); }
        public static readonly long SYS_MREMAP = (long)411L; // { void *|sys||mremap(void *old_address, size_t old_size, void *new_address, size_t new_size, int flags); }
        public static readonly long SYS_PSET_CREATE = (long)412L; // { int|sys||pset_create(psetid_t *psid); }
        public static readonly long SYS_PSET_DESTROY = (long)413L; // { int|sys||pset_destroy(psetid_t psid); }
        public static readonly long SYS_PSET_ASSIGN = (long)414L; // { int|sys||pset_assign(psetid_t psid, cpuid_t cpuid, psetid_t *opsid); }
        public static readonly long SYS__PSET_BIND = (long)415L; // { int|sys||_pset_bind(idtype_t idtype, id_t first_id, id_t second_id, psetid_t psid, psetid_t *opsid); }
        public static readonly long SYS_POSIX_FADVISE = (long)416L; // { int|sys|50|posix_fadvise(int fd, int PAD, off_t offset, off_t len, int advice); }
        public static readonly long SYS_SELECT = (long)417L; // { int|sys|50|select(int nd, fd_set *in, fd_set *ou, fd_set *ex, struct timeval *tv); }
        public static readonly long SYS_GETTIMEOFDAY = (long)418L; // { int|sys|50|gettimeofday(struct timeval *tp, void *tzp); }
        public static readonly long SYS_SETTIMEOFDAY = (long)419L; // { int|sys|50|settimeofday(const struct timeval *tv, const void *tzp); }
        public static readonly long SYS_UTIMES = (long)420L; // { int|sys|50|utimes(const char *path, const struct timeval *tptr); }
        public static readonly long SYS_ADJTIME = (long)421L; // { int|sys|50|adjtime(const struct timeval *delta, struct timeval *olddelta); }
        public static readonly long SYS_FUTIMES = (long)423L; // { int|sys|50|futimes(int fd, const struct timeval *tptr); }
        public static readonly long SYS_LUTIMES = (long)424L; // { int|sys|50|lutimes(const char *path, const struct timeval *tptr); }
        public static readonly long SYS_SETITIMER = (long)425L; // { int|sys|50|setitimer(int which, const struct itimerval *itv, struct itimerval *oitv); }
        public static readonly long SYS_GETITIMER = (long)426L; // { int|sys|50|getitimer(int which, struct itimerval *itv); }
        public static readonly long SYS_CLOCK_GETTIME = (long)427L; // { int|sys|50|clock_gettime(clockid_t clock_id, struct timespec *tp); }
        public static readonly long SYS_CLOCK_SETTIME = (long)428L; // { int|sys|50|clock_settime(clockid_t clock_id, const struct timespec *tp); }
        public static readonly long SYS_CLOCK_GETRES = (long)429L; // { int|sys|50|clock_getres(clockid_t clock_id, struct timespec *tp); }
        public static readonly long SYS_NANOSLEEP = (long)430L; // { int|sys|50|nanosleep(const struct timespec *rqtp, struct timespec *rmtp); }
        public static readonly long SYS___SIGTIMEDWAIT = (long)431L; // { int|sys|50|__sigtimedwait(const sigset_t *set, siginfo_t *info, struct timespec *timeout); }
        public static readonly long SYS__LWP_PARK = (long)434L; // { int|sys|50|_lwp_park(const struct timespec *ts, lwpid_t unpark, const void *hint, const void *unparkhint); }
        public static readonly long SYS_KEVENT = (long)435L; // { int|sys|50|kevent(int fd, const struct kevent *changelist, size_t nchanges, struct kevent *eventlist, size_t nevents, const struct timespec *timeout); }
        public static readonly long SYS_PSELECT = (long)436L; // { int|sys|50|pselect(int nd, fd_set *in, fd_set *ou, fd_set *ex, const struct timespec *ts, const sigset_t *mask); }
        public static readonly long SYS_POLLTS = (long)437L; // { int|sys|50|pollts(struct pollfd *fds, u_int nfds, const struct timespec *ts, const sigset_t *mask); }
        public static readonly long SYS_STAT = (long)439L; // { int|sys|50|stat(const char *path, struct stat *ub); }
        public static readonly long SYS_FSTAT = (long)440L; // { int|sys|50|fstat(int fd, struct stat *sb); }
        public static readonly long SYS_LSTAT = (long)441L; // { int|sys|50|lstat(const char *path, struct stat *ub); }
        public static readonly long SYS___SEMCTL = (long)442L; // { int|sys|50|__semctl(int semid, int semnum, int cmd, ... union __semun *arg); }
        public static readonly long SYS_SHMCTL = (long)443L; // { int|sys|50|shmctl(int shmid, int cmd, struct shmid_ds *buf); }
        public static readonly long SYS_MSGCTL = (long)444L; // { int|sys|50|msgctl(int msqid, int cmd, struct msqid_ds *buf); }
        public static readonly long SYS_GETRUSAGE = (long)445L; // { int|sys|50|getrusage(int who, struct rusage *rusage); }
        public static readonly long SYS_TIMER_SETTIME = (long)446L; // { int|sys|50|timer_settime(timer_t timerid, int flags, const struct itimerspec *value, struct itimerspec *ovalue); }
        public static readonly long SYS_TIMER_GETTIME = (long)447L; // { int|sys|50|timer_gettime(timer_t timerid, struct itimerspec *value); }
        public static readonly long SYS_NTP_GETTIME = (long)448L; // { int|sys|50|ntp_gettime(struct ntptimeval *ntvp); }
        public static readonly long SYS_WAIT4 = (long)449L; // { int|sys|50|wait4(pid_t pid, int *status, int options, struct rusage *rusage); }
        public static readonly long SYS_MKNOD = (long)450L; // { int|sys|50|mknod(const char *path, mode_t mode, dev_t dev); }
        public static readonly long SYS_FHSTAT = (long)451L; // { int|sys|50|fhstat(const void *fhp, size_t fh_size, struct stat *sb); }
        public static readonly long SYS_PIPE2 = (long)453L; // { int|sys||pipe2(int *fildes, int flags); }
        public static readonly long SYS_DUP3 = (long)454L; // { int|sys||dup3(int from, int to, int flags); }
        public static readonly long SYS_KQUEUE1 = (long)455L; // { int|sys||kqueue1(int flags); }
        public static readonly long SYS_PACCEPT = (long)456L; // { int|sys||paccept(int s, struct sockaddr *name, socklen_t *anamelen, const sigset_t *mask, int flags); }
        public static readonly long SYS_LINKAT = (long)457L; // { int|sys||linkat(int fd1, const char *name1, int fd2, const char *name2, int flags); }
        public static readonly long SYS_RENAMEAT = (long)458L; // { int|sys||renameat(int fromfd, const char *from, int tofd, const char *to); }
        public static readonly long SYS_MKFIFOAT = (long)459L; // { int|sys||mkfifoat(int fd, const char *path, mode_t mode); }
        public static readonly long SYS_MKNODAT = (long)460L; // { int|sys||mknodat(int fd, const char *path, mode_t mode, uint32_t dev); }
        public static readonly long SYS_MKDIRAT = (long)461L; // { int|sys||mkdirat(int fd, const char *path, mode_t mode); }
        public static readonly long SYS_FACCESSAT = (long)462L; // { int|sys||faccessat(int fd, const char *path, int amode, int flag); }
        public static readonly long SYS_FCHMODAT = (long)463L; // { int|sys||fchmodat(int fd, const char *path, mode_t mode, int flag); }
        public static readonly long SYS_FCHOWNAT = (long)464L; // { int|sys||fchownat(int fd, const char *path, uid_t owner, gid_t group, int flag); }
        public static readonly long SYS_FEXECVE = (long)465L; // { int|sys||fexecve(int fd, char * const *argp, char * const *envp); }
        public static readonly long SYS_FSTATAT = (long)466L; // { int|sys||fstatat(int fd, const char *path, struct stat *buf, int flag); }
        public static readonly long SYS_UTIMENSAT = (long)467L; // { int|sys||utimensat(int fd, const char *path, const struct timespec *tptr, int flag); }
        public static readonly long SYS_OPENAT = (long)468L; // { int|sys||openat(int fd, const char *path, int oflags, ... mode_t mode); }
        public static readonly long SYS_READLINKAT = (long)469L; // { int|sys||readlinkat(int fd, const char *path, char *buf, size_t bufsize); }
        public static readonly long SYS_SYMLINKAT = (long)470L; // { int|sys||symlinkat(const char *path1, int fd, const char *path2); }
        public static readonly long SYS_UNLINKAT = (long)471L; // { int|sys||unlinkat(int fd, const char *path, int flag); }
        public static readonly long SYS_FUTIMENS = (long)472L; // { int|sys||futimens(int fd, const struct timespec *tptr); }
        public static readonly long SYS___QUOTACTL = (long)473L; // { int|sys||__quotactl(const char *path, struct quotactl_args *args); }
        public static readonly long SYS_POSIX_SPAWN = (long)474L; // { int|sys||posix_spawn(pid_t *pid, const char *path, const struct posix_spawn_file_actions *file_actions, const struct posix_spawnattr *attrp, char *const *argv, char *const *envp); }
        public static readonly long SYS_RECVMMSG = (long)475L; // { int|sys||recvmmsg(int s, struct mmsghdr *mmsg, unsigned int vlen, unsigned int flags, struct timespec *timeout); }
        public static readonly long SYS_SENDMMSG = (long)476L; // { int|sys||sendmmsg(int s, struct mmsghdr *mmsg, unsigned int vlen, unsigned int flags); }
    }
}}}}}}
