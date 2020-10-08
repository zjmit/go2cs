// Copyright 2018 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// The toolexec program is a helper program for cmd/cover tests.
// It is used so that the go tool will call the newly built version
// of the cover program, rather than the installed one.
//
// The tests arrange to run the go tool with the argument
//    -toolexec="/path/to/toolexec /path/to/testcover"
// The go tool will invoke this program (compiled into /path/to/toolexec)
// with the arguments shown above followed by the command to run.
// This program will check whether it is expected to run the cover
// program, and if so replace it with /path/to/testcover.
// package main -- go2cs converted at 2020 October 08 04:32:38 UTC
// Original source: C:\Go\src\cmd\cover\testdata\toolexec.go
using os = go.os_package;
using exec = go.os.exec_package;
using strings = go.strings_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        private static void Main()
        {
            if (strings.HasSuffix(strings.TrimSuffix(os.Args[2L], ".exe"), "cover"))
            {
                os.Args[2L] = os.Args[1L];
            }
            var cmd = exec.Command(os.Args[2L], os.Args[3L..]);
            cmd.Stdout = os.Stdout;
            cmd.Stderr = os.Stderr;
            {
                var err = cmd.Run();

                if (err != null)
                {
                    os.Exit(1L);
                }
            }

        }
    }
}
