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
    /// 修改数据库备注请求体。
    /// </summary>
    public class UpdateDatabaseCommentRequest 
    {

        /// <summary>
        /// 准备修改备注的数据库列表，列表最大长度为50。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateDatabaseComment> Databases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDatabaseCommentRequest {\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDatabaseCommentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDatabaseCommentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Databases == input.Databases ||
                    this.Databases != null &&
                    input.Databases != null &&
                    this.Databases.SequenceEqual(input.Databases)
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
                if (this.Databases != null)
                    hashCode = hashCode * 59 + this.Databases.GetHashCode();
                return hashCode;
            }
        }
    }
}
