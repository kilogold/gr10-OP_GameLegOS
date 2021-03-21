using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Contracts.Contracts.Faucet.ContractDefinition
{


    public partial class FaucetDeployment : FaucetDeploymentBase
    {
        public FaucetDeployment() : base(BYTECODE) { }
        public FaucetDeployment(string byteCode) : base(byteCode) { }
    }

    public class FaucetDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "6080604052600360015560405161042e38038061042e83398101604081905261002791610041565b600155600280546001600160a01b03191633179055610059565b600060208284031215610052578081fd5b5051919050565b6103c6806100686000396000f3fe608060405234801561001057600080fd5b50600436106100415760003560e01c80636370920e146100465780636bb76ce41461005b578063cfc871cf14610081575b600080fd5b6100596100543660046102cb565b6100a4565b005b61006e6100693660046102aa565b610224565b6040519081526020015b60405180910390f35b61009461008f3660046102aa565b61024f565b6040519015158152602001610078565b6002546001600160a01b031633146100bb57600080fd5b6100c48261024f565b6100cd57600080fd5b60006100d882610280565b6040516370a0823160e01b815230600482015290915073fab46e002bbf0b4509813474841e0716e6730136906370a082319060240160206040518083038186803b15801561012557600080fd5b505afa158015610139573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061015d9190610314565b81111561016957600080fd5b60405163a9059cbb60e01b81526001600160a01b03841660048201526024810182905273fab46e002bbf0b4509813474841e0716e67301369063a9059cbb90604401602060405180830381600087803b1580156101c557600080fd5b505af11580156101d9573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906101fd91906102f4565b61020657600080fd5b50506001600160a01b03166000908152602081905260409020429055565b6001600160a01b0381166000908152602081905260408120546102479042610363565b90505b919050565b6001546001600160a01b03821660009081526020819052604081205490914291610279919061032c565b1092915050565b60006102478266038d7ea4c68000610344565b80356001600160a01b038116811461024a57600080fd5b6000602082840312156102bb578081fd5b6102c482610293565b9392505050565b600080604083850312156102dd578081fd5b6102e683610293565b946020939093013593505050565b600060208284031215610305578081fd5b815180151581146102c4578182fd5b600060208284031215610325578081fd5b5051919050565b6000821982111561033f5761033f61037a565b500190565b600081600019048311821515161561035e5761035e61037a565b500290565b6000828210156103755761037561037a565b500390565b634e487b7160e01b600052601160045260246000fdfea264697066735822122033501e30135492037e2c20df8098523fba670293e1fbb0b6ca5ed3ad1f2cde6464736f6c63430008020033";
        public FaucetDeploymentBase() : base(BYTECODE) { }
        public FaucetDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("uint256", "retryAmount", 1)]
        public virtual BigInteger RetryAmount { get; set; }
    }

    public partial class CanParticipateFunction : CanParticipateFunctionBase { }

    [Function("canParticipate", "bool")]
    public class CanParticipateFunctionBase : FunctionMessage
    {
        [Parameter("address", "participant", 1)]
        public virtual string Participant { get; set; }
    }

    public partial class GetElapsedTimeFunction : GetElapsedTimeFunctionBase { }

    [Function("getElapsedTime", "uint256")]
    public class GetElapsedTimeFunctionBase : FunctionMessage
    {
        [Parameter("address", "participant", 1)]
        public virtual string Participant { get; set; }
    }

    public partial class GrantFunction : GrantFunctionBase { }

    [Function("grant")]
    public class GrantFunctionBase : FunctionMessage
    {
        [Parameter("address", "recipient", 1)]
        public virtual string Recipient { get; set; }
        [Parameter("uint256", "score", 2)]
        public virtual BigInteger Score { get; set; }
    }

    public partial class CanParticipateOutputDTO : CanParticipateOutputDTOBase { }

    [FunctionOutput]
    public class CanParticipateOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class GetElapsedTimeOutputDTO : GetElapsedTimeOutputDTOBase { }

    [FunctionOutput]
    public class GetElapsedTimeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }


}
