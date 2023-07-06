using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 数据库对象信息体
    /// </summary>
    public class DatabaseObjectVO 
    {

        /// <summary>
        /// 数据库对象和数据库表名称，例如格式为hec-*-*-drs_test1。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否选择高级配置，值为true。
        /// </summary>
        [JsonProperty("select", NullValueHandling = NullValueHandling.Ignore)]
        public string Select { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseObjectVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  select: ").Append(Select).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseObjectVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseObjectVO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Select == input.Select ||
                    (this.Select != null &&
                    this.Select.Equals(input.Select))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Select != null)
                    hashCode = hashCode * 59 + this.Select.GetHashCode();
                return hashCode;
            }
        }
    }
}
