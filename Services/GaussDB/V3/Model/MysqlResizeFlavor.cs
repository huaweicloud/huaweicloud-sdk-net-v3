using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlResizeFlavor 
    {

        /// <summary>
        /// 规格码
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlResizeFlavor {\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlResizeFlavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlResizeFlavor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
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
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
