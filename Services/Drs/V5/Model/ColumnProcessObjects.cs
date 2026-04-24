using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 列加工对象
    /// </summary>
    public class ColumnProcessObjects 
    {

        /// <summary>
        /// 选择的源库对象名
        /// </summary>
        [JsonProperty("object_source_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ObjectSourceNames { get; set; }

        /// <summary>
        /// 映射后的对象名
        /// </summary>
        [JsonProperty("object_alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectAliasName { get; set; }

        /// <summary>
        /// 附加列是否已下发
        /// </summary>
        [JsonProperty("is_sent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSent { get; set; }

        /// <summary>
        /// 附加列信息
        /// </summary>
        [JsonProperty("extra_column_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddColumnInfo> ExtraColumnInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnProcessObjects {\n");
            sb.Append("  objectSourceNames: ").Append(ObjectSourceNames).Append("\n");
            sb.Append("  objectAliasName: ").Append(ObjectAliasName).Append("\n");
            sb.Append("  isSent: ").Append(IsSent).Append("\n");
            sb.Append("  extraColumnInfos: ").Append(ExtraColumnInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColumnProcessObjects);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColumnProcessObjects input)
        {
            if (input == null) return false;
            if (this.ObjectSourceNames != input.ObjectSourceNames || (this.ObjectSourceNames != null && input.ObjectSourceNames != null && !this.ObjectSourceNames.SequenceEqual(input.ObjectSourceNames))) return false;
            if (this.ObjectAliasName != input.ObjectAliasName || (this.ObjectAliasName != null && !this.ObjectAliasName.Equals(input.ObjectAliasName))) return false;
            if (this.IsSent != input.IsSent || (this.IsSent != null && !this.IsSent.Equals(input.IsSent))) return false;
            if (this.ExtraColumnInfos != input.ExtraColumnInfos || (this.ExtraColumnInfos != null && input.ExtraColumnInfos != null && !this.ExtraColumnInfos.SequenceEqual(input.ExtraColumnInfos))) return false;

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
                if (this.ObjectSourceNames != null) hashCode = hashCode * 59 + this.ObjectSourceNames.GetHashCode();
                if (this.ObjectAliasName != null) hashCode = hashCode * 59 + this.ObjectAliasName.GetHashCode();
                if (this.IsSent != null) hashCode = hashCode * 59 + this.IsSent.GetHashCode();
                if (this.ExtraColumnInfos != null) hashCode = hashCode * 59 + this.ExtraColumnInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
