﻿/*
   Copyright 2021 Lip Wee Yeo Amano

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace Crypto_LP_Compounder.DTO.Farm
{
    public abstract class MasterChef
    {
        [FunctionOutput]
        public class UserInfoFunctionOutputDTO : IFunctionOutputDTO
        {
            [Parameter("uint256", "amount", 1)]
            public BigInteger Amount { get; set; }

            [Parameter("uint256", "rewardDebt", 2)]
            public BigInteger RewardDebt { get; set; }
        }

        [Function("deposit")]
        public class DepositFunction : FunctionMessage
        {
            [Parameter("uint256", "_pid", 1)]
            public BigInteger PoolID { get; set; }

            [Parameter("uint256", "_amount", 2)]
            public BigInteger Amount { get; set; }
        }

        [Function("totalAllocPoint", "uint256")]
        public class TotalAllocPoint : FunctionMessage
        {
        }

        [Function("userInfo", typeof(UserInfoFunctionOutputDTO))]
        public class UserInfoFunction : FunctionMessage
        {
            [Parameter("uint256", "", 1)]
            public BigInteger PoolID { get; set; }

            [Parameter("address", "", 2)]
            public string User { get; set; }
        }

        [Function("withdraw")]
        public class WithdrawFunction : FunctionMessage
        {
            [Parameter("uint256", "_pid", 1)]
            public BigInteger PoolID { get; set; }

            [Parameter("uint256", "_amount", 2)]
            public BigInteger Amount { get; set; }
        }
    }
}
