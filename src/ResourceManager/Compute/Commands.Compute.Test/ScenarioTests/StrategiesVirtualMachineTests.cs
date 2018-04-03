﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Microsoft.Azure.Commands.Compute.Test.ScenarioTests
{
    public class StrategiesVirtualMachineTests
    {
        public StrategiesVirtualMachineTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            ServiceManagemenet.Common.Models.XunitTracingInterceptor.AddToContext(new ServiceManagemenet.Common.Models.XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSimpleNewVm()
        {
            ComputeTestController.NewInstance.RunPsTest("Test-SimpleNewVm");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSimpleNewVmWithSystemAssignedIdentity()
        {
            ComputeTestController.NewInstance.RunPsTest("Test-SimpleNewVmSystemAssignedIdentity");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSimpleNewVmWithUserAssignedIdentity()
        {
            /**
             * To record this test run these commands first :
             * New-AzureRmResourceGroup -Name UAITG123456 -Location 'Central US'
             * New-AzureRmUserAssignedIdentity -ResourceGroupName  UAITG123456 -NameUAITG123456Identity
             * 
             * Now get the identity :
             * 
             * Get-AzureRmUserAssignedIdentity -ResourceGroupName UAITG123456 -Name UAITG123456Identity
             * Nore down the Id and use it in the PS code
             * */
            ComputeTestController.NewInstance.RunPsTest("Test-SimpleNewVmUserAssignedIdentity");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSimpleNewVmWithSystemAssignedAndUserAssignedIdentity()
        {
            /**
             * To record this test run these commands first :
             * New-AzureRmResourceGroup -Name UAITG123456 -Location 'Central US'
             * New-AzureRmUserAssignedIdentity -ResourceGroupName  UAITG123456 -NameUAITG123456Identity
             * 
             * Now get the identity :
             * 
             * Get-AzureRmUserAssignedIdentity -ResourceGroupName UAITG123456 -Name UAITG123456Identity
             * Nore down the Id and use it in the PS code
             * */
            ComputeTestController.NewInstance.RunPsTest("Test-SimpleNewVmUserAssignedIdentitySystemAssignedIdentity");
        }

        [Fact] 
        [Trait(Category.AcceptanceType, Category.CheckIn)] 
        public void TestSimpleNewVmWithAvailabilitySet2()
        { 
            ComputeTestController.NewInstance.RunPsTest("Test-SimpleNewVmWithAvailabilitySet2"); 
        }
    }
}
