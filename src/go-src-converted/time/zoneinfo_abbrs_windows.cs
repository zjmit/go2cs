// Copyright 2013 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Code generated by genzabbrs.go; DO NOT EDIT.
// Based on information from https://raw.githubusercontent.com/unicode-org/cldr/master/common/supplemental/windowsZones.xml

// package time -- go2cs converted at 2020 October 08 03:45:50 UTC
// import "time" ==> using time = go.time_package
// Original source: C:\Go\src\time\zoneinfo_abbrs_windows.go

using static go.builtin;

namespace go
{
    public static partial class time_package
    {
        private partial struct abbr
        {
            public @string std;
            public @string dst;
        }

        private static map abbrs = /* TODO: Fix this in ScannerBase_Expression::ExitCompositeLit */ new map<@string, abbr>{"Egypt Standard Time":{"EET","EET"},"Morocco Standard Time":{"+00","+01"},"South Africa Standard Time":{"SAST","SAST"},"Sudan Standard Time":{"CAT","CAT"},"W. Central Africa Standard Time":{"WAT","WAT"},"E. Africa Standard Time":{"EAT","EAT"},"Sao Tome Standard Time":{"GMT","WAT"},"Libya Standard Time":{"EET","EET"},"Namibia Standard Time":{"CAT","CAT"},"Aleutian Standard Time":{"HST","HDT"},"Alaskan Standard Time":{"AKST","AKDT"},"Tocantins Standard Time":{"-03","-03"},"Paraguay Standard Time":{"-04","-03"},"Bahia Standard Time":{"-03","-03"},"SA Pacific Standard Time":{"-05","-05"},"Argentina Standard Time":{"-03","-03"},"Eastern Standard Time (Mexico)":{"EST","EST"},"Venezuela Standard Time":{"-04","-04"},"SA Eastern Standard Time":{"-03","-03"},"Central Standard Time":{"CST","CDT"},"Mountain Standard Time (Mexico)":{"MST","MDT"},"Central Brazilian Standard Time":{"-04","-03"},"Mountain Standard Time":{"MST","MDT"},"Greenland Standard Time":{"-03","-02"},"Turks And Caicos Standard Time":{"EST","EDT"},"Central America Standard Time":{"CST","CST"},"Atlantic Standard Time":{"AST","ADT"},"Cuba Standard Time":{"CST","CDT"},"US Eastern Standard Time":{"EST","EDT"},"SA Western Standard Time":{"-04","-04"},"Pacific Standard Time":{"PST","PDT"},"Central Standard Time (Mexico)":{"CST","CDT"},"Saint Pierre Standard Time":{"-03","-02"},"Montevideo Standard Time":{"-03","-03"},"Eastern Standard Time":{"EST","EDT"},"US Mountain Standard Time":{"MST","MST"},"Haiti Standard Time":{"EST","EDT"},"Magallanes Standard Time":{"-03","-03"},"Canada Central Standard Time":{"CST","CST"},"Pacific SA Standard Time":{"-04","-03"},"E. South America Standard Time":{"-03","-02"},"Newfoundland Standard Time":{"NST","NDT"},"Pacific Standard Time (Mexico)":{"PST","PDT"},"Central Asia Standard Time":{"+06","+06"},"Jordan Standard Time":{"EET","EEST"},"Arabic Standard Time":{"+03","+03"},"Azerbaijan Standard Time":{"+04","+04"},"SE Asia Standard Time":{"+07","+07"},"Altai Standard Time":{"+07","+07"},"Middle East Standard Time":{"EET","EEST"},"India Standard Time":{"IST","IST"},"Transbaikal Standard Time":{"+09","+09"},"Sri Lanka Standard Time":{"+0530","+0530"},"Syria Standard Time":{"EET","EEST"},"Bangladesh Standard Time":{"+06","+06"},"Arabian Standard Time":{"+04","+04"},"West Bank Standard Time":{"EET","EEST"},"W. Mongolia Standard Time":{"+07","+07"},"North Asia East Standard Time":{"+08","+08"},"Israel Standard Time":{"IST","IDT"},"Afghanistan Standard Time":{"+0430","+0430"},"Russia Time Zone 11":{"+12","+12"},"Pakistan Standard Time":{"PKT","PKT"},"Nepal Standard Time":{"+0545","+0545"},"North Asia Standard Time":{"+07","+07"},"Magadan Standard Time":{"+11","+11"},"N. Central Asia Standard Time":{"+07","+07"},"Omsk Standard Time":{"+06","+06"},"North Korea Standard Time":{"KST","KST"},"Qyzylorda Standard Time":{"+05","+06"},"Myanmar Standard Time":{"+0630","+0630"},"Arab Standard Time":{"+03","+03"},"Sakhalin Standard Time":{"+11","+11"},"Korea Standard Time":{"KST","KST"},"China Standard Time":{"CST","CST"},"Singapore Standard Time":{"+08","+08"},"Russia Time Zone 10":{"+11","+11"},"Taipei Standard Time":{"CST","CST"},"West Asia Standard Time":{"+05","+05"},"Georgian Standard Time":{"+04","+04"},"Iran Standard Time":{"+0330","+0430"},"Tokyo Standard Time":{"JST","JST"},"Tomsk Standard Time":{"+07","+07"},"Ulaanbaatar Standard Time":{"+08","+08"},"Vladivostok Standard Time":{"+10","+10"},"Yakutsk Standard Time":{"+09","+09"},"Ekaterinburg Standard Time":{"+05","+05"},"Caucasus Standard Time":{"+04","+04"},"Azores Standard Time":{"-01","+00"},"Cape Verde Standard Time":{"-01","-01"},"Greenwich Standard Time":{"GMT","GMT"},"Cen. Australia Standard Time":{"ACST","ACDT"},"E. Australia Standard Time":{"AEST","AEST"},"AUS Central Standard Time":{"ACST","ACST"},"Aus Central W. Standard Time":{"+0845","+0845"},"Tasmania Standard Time":{"AEST","AEDT"},"Lord Howe Standard Time":{"+1030","+11"},"W. Australia Standard Time":{"AWST","AWST"},"AUS Eastern Standard Time":{"AEST","AEDT"},"UTC":{"GMT","GMT"},"UTC-11":{"-11","-11"},"Dateline Standard Time":{"-12","-12"},"UTC-02":{"-02","-02"},"UTC-08":{"-08","-08"},"UTC-09":{"-09","-09"},"UTC+12":{"+12","+12"},"UTC+13":{"+13","+13"},"Astrakhan Standard Time":{"+04","+04"},"W. Europe Standard Time":{"CET","CEST"},"GTB Standard Time":{"EET","EEST"},"Central Europe Standard Time":{"CET","CEST"},"E. Europe Standard Time":{"EET","EEST"},"Turkey Standard Time":{"+03","+03"},"Kaliningrad Standard Time":{"EET","EET"},"FLE Standard Time":{"EET","EEST"},"GMT Standard Time":{"GMT","BST"},"Belarus Standard Time":{"+03","+03"},"Russian Standard Time":{"MSK","MSK"},"Romance Standard Time":{"CET","CEST"},"Russia Time Zone 3":{"+04","+04"},"Saratov Standard Time":{"+04","+04"},"Volgograd Standard Time":{"+04","+04"},"Central European Standard Time":{"CET","CEST"},"Mauritius Standard Time":{"+04","+04"},"Samoa Standard Time":{"+13","+14"},"New Zealand Standard Time":{"NZST","NZDT"},"Bougainville Standard Time":{"+11","+11"},"Chatham Islands Standard Time":{"+1245","+1345"},"Easter Island Standard Time":{"-06","-05"},"Fiji Standard Time":{"+12","+13"},"Central Pacific Standard Time":{"+11","+11"},"Hawaiian Standard Time":{"HST","HST"},"Line Islands Standard Time":{"+14","+14"},"Marquesas Standard Time":{"-0930","-0930"},"Norfolk Standard Time":{"+11","+11"},"West Pacific Standard Time":{"+10","+10"},"Tonga Standard Time":{"+13","+13"},};
    }
}
