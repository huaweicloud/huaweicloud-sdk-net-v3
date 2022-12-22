using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListIssueCustomFieldsResponse : SdkResponse
    {

        /// <summary>
        /// 自定义字段返回数据
        /// </summary>
        [JsonProperty("datas", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueCustomField> Datas { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIssueCustomFieldsResponse {\n");
            sb.Append("  datas: ").Append(Datas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIssueCustomFieldsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIssueCustomFieldsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Datas == input.Datas ||
                    this.Datas != null &&
                    input.Datas != null &&
                    this.Datas.SequenceEqual(input.Datas)
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
                if (this.Datas != null)
                    hashCode = hashCode * 59 + this.Datas.GetHashCode();
                return hashCode;
            }
        }
    }
}
