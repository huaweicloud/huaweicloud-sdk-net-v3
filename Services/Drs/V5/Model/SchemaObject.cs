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
    /// 数据库模式对象。
    /// </summary>
    public class SchemaObject 
    {

        /// <summary>
        /// 该模式在实时同步场景下的类型。取值： - config：仅当该模式作为数据过滤高级设置的关联模式时，需要填写，此时该模式以及该模式下的tables“不会”被同步到目标库，name、all属性不生效，tables需要填写被关联的相关对象。（注意：如果需要同步该模式对象，则在下级对象中填写sync_type值为config。）
        /// </summary>
        [JsonProperty("sync_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncType { get; set; }

        /// <summary>
        /// 该模式在目标库的名称（模式名映射）。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否整模式迁移或同步。注意： 1.当该模式下的表、列需要做数据过滤、列过滤、列映射时，填false，否则填true； 2.当该模式下的表需要做附加列时，需要填true，并且在表级对象的columns里填写附加列信息； 3.当该模式下的表所包含的列作为数据过滤高级设置的关联列时，需要填true，并且在columns里填写关联列信息、config_conditions填写数据过滤高级设置的配置条件；
        /// </summary>
        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? All { get; set; }

        /// <summary>
        /// 需要迁移或同步的表，当整模式迁移或同步为false时需要填写。
        /// </summary>
        [JsonProperty("tables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TableObject> Tables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemaObject {\n");
            sb.Append("  syncType: ").Append(SyncType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  all: ").Append(All).Append("\n");
            sb.Append("  tables: ").Append(Tables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SchemaObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SchemaObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SyncType == input.SyncType ||
                    (this.SyncType != null &&
                    this.SyncType.Equals(input.SyncType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
                ) && 
                (
                    this.Tables == input.Tables ||
                    this.Tables != null &&
                    input.Tables != null &&
                    this.Tables.SequenceEqual(input.Tables)
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
                if (this.SyncType != null)
                    hashCode = hashCode * 59 + this.SyncType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.Tables != null)
                    hashCode = hashCode * 59 + this.Tables.GetHashCode();
                return hashCode;
            }
        }
    }
}
