using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateRandomResponse : SdkResponse
    {

        /// <summary>
        /// 随机数16进制表示，两位表示1byte。随机数的长度与用户传入的参数 “random_data_length”的长度保持一致。
        /// </summary>
        [JsonProperty("random_data", NullValueHandling = NullValueHandling.Ignore)]
        public string RandomData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRandomResponse {\n");
            sb.Append("  randomData: ").Append(RandomData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRandomResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRandomResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RandomData == input.RandomData ||
                    (this.RandomData != null &&
                    this.RandomData.Equals(input.RandomData))
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
                if (this.RandomData != null)
                    hashCode = hashCode * 59 + this.RandomData.GetHashCode();
                return hashCode;
            }
        }
    }
}
