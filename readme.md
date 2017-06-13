This solution is the repro to a bug in the vstest.console.exe on VS2017 enterprise.

The following commandline shows the crash:

"C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" "bin\x64\Debug\UnitTestProject1.dll" /EnableCodeCoverage /Platform:x64 /logger:trx

De output shows

    Microsoft (R) Test Execution Command Line Tool Version 15.0.26228.0
    Copyright (c) Microsoft Corporation.  All rights reserved.
    
    Starting test execution, please wait...
    Warning: Using Isolation mode to run tests as required by effective Platform:X64 and .Net Framework:Framework45 settings for test run. Use the /inIsolation parameter to suppress this warning.
    
    Error: The active Test Run was aborted because the execution process exited unexpectedly. The test execution process crashed while running the tests. To investigate further, open file:///[SNIP]vstest.executionengine.exe.10172.dmp file in Visual Studio and choose "Debug in mixed mode".


