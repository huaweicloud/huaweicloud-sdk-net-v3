using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 激活码信息。
    /// </summary>
    public class QueryVisionActiveCodeResultDTO 
    {

        /// <summary>
        /// 激活码唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 激活码。
        /// </summary>
        [JsonProperty("activeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveCode { get; set; }

        /// <summary>
        /// 终端名称。
        /// </summary>
        [JsonProperty("devName", NullValueHandling = NullValueHandling.Ignore)]
        public string DevName { get; set; }

        /// <summary>
        /// 终端类型。
        /// </summary>
        [JsonProperty("devType", NullValueHandling = NullValueHandling.Ignore)]
        public string DevType { get; set; }

        /// <summary>
        /// 部门编码。
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 失效时间戳。
        /// </summary>
        [JsonProperty("expireDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryVisionActiveCodeResultDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  activeCode: ").Append(ActiveCode).Append("\n");
            sb.Append("  devName: ").Append(DevName).Append("\n");
            sb.Append("  devType: ").Append(DevType).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  expireDate: ").Append(ExpireDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryVisionActiveCodeResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryVisionActiveCodeResultDTO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ActiveCode != input.ActiveCode || (this.ActiveCode != null && !this.ActiveCode.Equals(input.ActiveCode))) return false;
            if (this.DevName != input.DevName || (this.DevName != null && !this.DevName.Equals(input.DevName))) return false;
            if (this.DevType != input.DevType || (this.DevType != null && !this.DevType.Equals(input.DevType))) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.ExpireDate != input.ExpireDate || (this.ExpireDate != null && !this.ExpireDate.Equals(input.ExpireDate))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ActiveCode != null) hashCode = hashCode * 59 + this.ActiveCode.GetHashCode();
                if (this.DevName != null) hashCode = hashCode * 59 + this.DevName.GetHashCode();
                if (this.DevType != null) hashCode = hashCode * 59 + this.DevType.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.ExpireDate != null) hashCode = hashCode * 59 + this.ExpireDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
