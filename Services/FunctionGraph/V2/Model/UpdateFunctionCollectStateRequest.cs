using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateFunctionCollectStateRequest 
    {

        /// <summary>
        /// 函数URN
        /// </summary>
        [SDKProperty("func_urn", IsPath = true)]
        [JsonProperty("func_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncUrn { get; set; }

        /// <summary>
        /// 收藏状态
        /// </summary>
        [SDKProperty("state", IsPath = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFunctionCollectStateRequest {\n");
            sb.Append("  funcUrn: ").Append(FuncUrn).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFunctionCollectStateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFunctionCollectStateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FuncUrn == input.FuncUrn ||
                    (this.FuncUrn != null &&
                    this.FuncUrn.Equals(input.FuncUrn))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FuncUrn != null)
                    hashCode = hashCode * 59 + this.FuncUrn.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }
}
