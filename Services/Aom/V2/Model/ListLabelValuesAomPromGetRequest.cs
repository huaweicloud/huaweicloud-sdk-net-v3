using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListLabelValuesAomPromGetRequest 
    {

        /// <summary>
        /// 查询所用标签。
        /// </summary>
        [SDKProperty("label_name", IsPath = true)]
        [JsonProperty("label_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLabelValuesAomPromGetRequest {\n");
            sb.Append("  labelName: ").Append(LabelName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLabelValuesAomPromGetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLabelValuesAomPromGetRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LabelName == input.LabelName ||
                    (this.LabelName != null &&
                    this.LabelName.Equals(input.LabelName))
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
                if (this.LabelName != null)
                    hashCode = hashCode * 59 + this.LabelName.GetHashCode();
                return hashCode;
            }
        }
    }
}
