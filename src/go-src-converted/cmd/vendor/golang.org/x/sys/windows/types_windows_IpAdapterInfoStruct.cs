//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using net = go.net_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IpAdapterInfo
        {
            // Constructors
            public IpAdapterInfo(NilType _)
            {
                this.Next = default;
                this.ComboIndex = default;
                this.AdapterName = default;
                this.Description = default;
                this.AddressLength = default;
                this.Address = default;
                this.Index = default;
                this.Type = default;
                this.DhcpEnabled = default;
                this.CurrentIpAddress = default;
                this.IpAddressList = default;
                this.GatewayList = default;
                this.DhcpServer = default;
                this.HaveWins = default;
                this.PrimaryWinsServer = default;
                this.SecondaryWinsServer = default;
                this.LeaseObtained = default;
                this.LeaseExpires = default;
            }

            public IpAdapterInfo(ref ptr<IpAdapterInfo> Next = default, uint ComboIndex = default, array<byte> AdapterName = default, array<byte> Description = default, uint AddressLength = default, array<byte> Address = default, uint Index = default, uint Type = default, uint DhcpEnabled = default, ref ptr<IpAddrString> CurrentIpAddress = default, IpAddrString IpAddressList = default, IpAddrString GatewayList = default, IpAddrString DhcpServer = default, bool HaveWins = default, IpAddrString PrimaryWinsServer = default, IpAddrString SecondaryWinsServer = default, long LeaseObtained = default, long LeaseExpires = default)
            {
                this.Next = Next;
                this.ComboIndex = ComboIndex;
                this.AdapterName = AdapterName;
                this.Description = Description;
                this.AddressLength = AddressLength;
                this.Address = Address;
                this.Index = Index;
                this.Type = Type;
                this.DhcpEnabled = DhcpEnabled;
                this.CurrentIpAddress = CurrentIpAddress;
                this.IpAddressList = IpAddressList;
                this.GatewayList = GatewayList;
                this.DhcpServer = DhcpServer;
                this.HaveWins = HaveWins;
                this.PrimaryWinsServer = PrimaryWinsServer;
                this.SecondaryWinsServer = SecondaryWinsServer;
                this.LeaseObtained = LeaseObtained;
                this.LeaseExpires = LeaseExpires;
            }

            // Enable comparisons between nil and IpAdapterInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IpAdapterInfo value, NilType nil) => value.Equals(default(IpAdapterInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IpAdapterInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IpAdapterInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IpAdapterInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IpAdapterInfo(NilType nil) => default(IpAdapterInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IpAdapterInfo IpAdapterInfo_cast(dynamic value)
        {
            return new IpAdapterInfo(ref value.Next, value.ComboIndex, value.AdapterName, value.Description, value.AddressLength, value.Address, value.Index, value.Type, value.DhcpEnabled, ref value.CurrentIpAddress, value.IpAddressList, value.GatewayList, value.DhcpServer, value.HaveWins, value.PrimaryWinsServer, value.SecondaryWinsServer, value.LeaseObtained, value.LeaseExpires);
        }
    }
}}}}}}