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
    /// 
    /// </summary>
    public class ListAccessPointResponseBodyAccessPoints 
    {

        /// <summary>
        /// **参数解释：** 接入点ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("access_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// **参数解释：** 密钥空间ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("keyspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyspaceId { get; set; }

        /// <summary>
        /// **参数解释：** 接入点名称 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("access_point_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessPointName { get; set; }

        /// <summary>
        /// **参数解释：** 接入点状态 **取值范围：** 0:禁用，1：启用
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public int? State { get; set; }

        /// <summary>
        /// **参数解释：** 接入点类型 **取值范围：** 1:ECS，2：CCE，3：Custom
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// **参数解释：** 接入点创建人 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// **参数解释：** 接入点创建时间 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释：** 接入点最近更新时间 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("lsat_modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LsatModifyTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAccessPointResponseBodyAccessPoints {\n");
            sb.Append("  accessPointId: ").Append(AccessPointId).Append("\n");
            sb.Append("  keyspaceId: ").Append(KeyspaceId).Append("\n");
            sb.Append("  accessPointName: ").Append(AccessPointName).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lsatModifyTime: ").Append(LsatModifyTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccessPointResponseBodyAccessPoints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccessPointResponseBodyAccessPoints input)
        {
            if (input == null) return false;
            if (this.AccessPointId != input.AccessPointId || (this.AccessPointId != null && !this.AccessPointId.Equals(input.AccessPointId))) return false;
            if (this.KeyspaceId != input.KeyspaceId || (this.KeyspaceId != null && !this.KeyspaceId.Equals(input.KeyspaceId))) return false;
            if (this.AccessPointName != input.AccessPointName || (this.AccessPointName != null && !this.AccessPointName.Equals(input.AccessPointName))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LsatModifyTime != input.LsatModifyTime || (this.LsatModifyTime != null && !this.LsatModifyTime.Equals(input.LsatModifyTime))) return false;

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
                if (this.AccessPointId != null) hashCode = hashCode * 59 + this.AccessPointId.GetHashCode();
                if (this.KeyspaceId != null) hashCode = hashCode * 59 + this.KeyspaceId.GetHashCode();
                if (this.AccessPointName != null) hashCode = hashCode * 59 + this.AccessPointName.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LsatModifyTime != null) hashCode = hashCode * 59 + this.LsatModifyTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
