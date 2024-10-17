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
    /// 实例磁盘类型信息。
    /// </summary>
    public class Storage 
    {

        /// <summary>
        /// 磁盘类型名称，可能取值如下： - ULTRAHIGH：表示SSD。 - LOCALSSD：表示本地SSD。 - CLOUDSSD：表示SSD云盘，仅支持通用型和独享型规格实例。 - ESSD：表示极速型SSD，仅支持独享型规格实例。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 其中key是可用区编号，value是规格所在az的状态，包含以下状态： - normal，在售。 - unsupported，暂不支持该规格。 - sellout，售罄。
        /// </summary>
        [JsonProperty("az_status", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AzStatus { get; set; }

        /// <summary>
        /// 性能规格，包含以下状态： - normal：通用增强型。 - normal2：通用增强Ⅱ型。 - armFlavors：鲲鹏通用增强型。 - dedicicatenormal ：x86独享型。 - armlocalssd：鲲鹏通用型。 - normallocalssd：x86通用型。 - general：通用型。 - dedicated：独享型，仅云盘SSD支持。 - rapid：独享型，仅极速型SSD支持。 - bigmen：超大内存型。
        /// </summary>
        [JsonProperty("support_compute_group_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportComputeGroupType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Storage {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  azStatus: ").Append(AzStatus).Append("\n");
            sb.Append("  supportComputeGroupType: ").Append(SupportComputeGroupType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Storage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Storage input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AzStatus != input.AzStatus || (this.AzStatus != null && input.AzStatus != null && !this.AzStatus.SequenceEqual(input.AzStatus))) return false;
            if (this.SupportComputeGroupType != input.SupportComputeGroupType || (this.SupportComputeGroupType != null && input.SupportComputeGroupType != null && !this.SupportComputeGroupType.SequenceEqual(input.SupportComputeGroupType))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AzStatus != null) hashCode = hashCode * 59 + this.AzStatus.GetHashCode();
                if (this.SupportComputeGroupType != null) hashCode = hashCode * 59 + this.SupportComputeGroupType.GetHashCode();
                return hashCode;
            }
        }
    }
}
