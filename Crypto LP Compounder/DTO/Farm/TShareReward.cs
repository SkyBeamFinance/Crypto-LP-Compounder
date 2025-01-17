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
    public class TShareReward : MasterChef
    {
        [FunctionOutput]
        public class PoolInfoOutputDTO : IFunctionOutputDTO
        {
            [Parameter("address", "token", 1)]
            public string Token { get; set; }

            [Parameter("uint256", "allocPoint", 2)]
            public BigInteger AllocPoint { get; set; }

            [Parameter("uint256", "lastRewardTime", 3)]
            public BigInteger LastRewardTime { get; set; }

            [Parameter("uint256", "accTSharePerShare", 4)]
            public BigInteger AccTSharePerShare { get; set; }

            [Parameter("bool", "isStarted", 5)]
            public bool IsStarted { get; set; }
        }

        [Function("pendingShare", "uint256")]
        public class PendingRewardFunction : FunctionMessage
        {
            [Parameter("uint256", "_pid", 1)]
            public BigInteger PoolID { get; set; }

            [Parameter("address", "_user", 2)]
            public string User { get; set; }
        }

        [Function("poolInfo", typeof(PoolInfoOutputDTO))]
        public class PoolInfo : FunctionMessage
        {
            [Parameter("uint256", "")]
            public BigInteger PoolID { get; set; }
        }

        [Function("tSharePerSecond", "uint256")]
        public class RewardPerSecondFunction : FunctionMessage
        {
        }
    }
}
