//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:58:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using driver = go.database.sql.driver_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

namespace go {
namespace database
{
    public static partial class sql_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct DB
        {
            // Constructors
            public DB(NilType _)
            {
                this.waitDuration = default;
                this.connector = default;
                this.numClosed = default;
                this.mu = default;
                this.freeConn = default;
                this.connRequests = default;
                this.nextRequest = default;
                this.numOpen = default;
                this.openerCh = default;
                this.closed = default;
                this.dep = default;
                this.lastPut = default;
                this.maxIdleCount = default;
                this.maxOpen = default;
                this.maxLifetime = default;
                this.maxIdleTime = default;
                this.cleanerCh = default;
                this.waitCount = default;
                this.maxIdleClosed = default;
                this.maxIdleTimeClosed = default;
                this.maxLifetimeClosed = default;
                this.stop = default;
            }

            public DB(long waitDuration = default, driver.Connector connector = default, ulong numClosed = default, sync.Mutex mu = default, slice<ptr<driverConn>> freeConn = default, map<ulong, channel<connRequest>> connRequests = default, ulong nextRequest = default, long numOpen = default, channel<object> openerCh = default, bool closed = default, map<finalCloser, depSet> dep = default, map<ptr<driverConn>, @string> lastPut = default, long maxIdleCount = default, long maxOpen = default, time.Duration maxLifetime = default, time.Duration maxIdleTime = default, channel<object> cleanerCh = default, long waitCount = default, long maxIdleClosed = default, long maxIdleTimeClosed = default, long maxLifetimeClosed = default, Action stop = default)
            {
                this.waitDuration = waitDuration;
                this.connector = connector;
                this.numClosed = numClosed;
                this.mu = mu;
                this.freeConn = freeConn;
                this.connRequests = connRequests;
                this.nextRequest = nextRequest;
                this.numOpen = numOpen;
                this.openerCh = openerCh;
                this.closed = closed;
                this.dep = dep;
                this.lastPut = lastPut;
                this.maxIdleCount = maxIdleCount;
                this.maxOpen = maxOpen;
                this.maxLifetime = maxLifetime;
                this.maxIdleTime = maxIdleTime;
                this.cleanerCh = cleanerCh;
                this.waitCount = waitCount;
                this.maxIdleClosed = maxIdleClosed;
                this.maxIdleTimeClosed = maxIdleTimeClosed;
                this.maxLifetimeClosed = maxLifetimeClosed;
                this.stop = stop;
            }

            // Enable comparisons between nil and DB struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(DB value, NilType nil) => value.Equals(default(DB));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(DB value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, DB value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, DB value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DB(NilType nil) => default(DB);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static DB DB_cast(dynamic value)
        {
            return new DB(value.waitDuration, value.connector, value.numClosed, value.mu, value.freeConn, value.connRequests, value.nextRequest, value.numOpen, value.openerCh, value.closed, value.dep, value.lastPut, value.maxIdleCount, value.maxOpen, value.maxLifetime, value.maxIdleTime, value.cleanerCh, value.waitCount, value.maxIdleClosed, value.maxIdleTimeClosed, value.maxLifetimeClosed, value.stop);
        }
    }
}}