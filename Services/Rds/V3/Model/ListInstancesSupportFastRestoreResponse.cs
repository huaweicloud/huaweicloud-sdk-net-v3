using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstancesSupportFastRestoreResponse : SdkResponse
    {

        /// <summary>
        /// 实例的极速恢复支持情况。
        /// </summary>
        [JsonProperty("support_fast_restore_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportFastRestoreList> SupportFastRestoreList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesSupportFastRestoreResponse {\n");
            sb.Append("  supportFastRestoreList: ").Append(SupportFastRestoreList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesSupportFastRestoreResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesSupportFastRestoreResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupportFastRestoreList == input.SupportFastRestoreList ||
                    this.SupportFastRestoreList != null &&
                    input.SupportFastRestoreList != null &&
                    this.SupportFastRestoreList.SequenceEqual(input.SupportFastRestoreList)
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
                if (this.SupportFastRestoreList != null)
                    hashCode = hashCode * 59 + this.SupportFastRestoreList.GetHashCode();
                return hashCode;
            }
        }
    }
}
