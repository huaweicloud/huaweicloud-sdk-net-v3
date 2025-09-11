using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SQLStatisticsBean 
    {

        /// <summary>
        /// 删除数量
        /// </summary>
        [JsonProperty("delete_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeleteNum { get; set; }

        /// <summary>
        /// 插入数量
        /// </summary>
        [JsonProperty("insert_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsertNum { get; set; }

        /// <summary>
        /// 其他数量
        /// </summary>
        [JsonProperty("other_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? OtherNum { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 查询数量
        /// </summary>
        [JsonProperty("select_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? SelectNum { get; set; }

        /// <summary>
        /// 更新数量
        /// </summary>
        [JsonProperty("update_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SQLStatisticsBean {\n");
            sb.Append("  deleteNum: ").Append(DeleteNum).Append("\n");
            sb.Append("  insertNum: ").Append(InsertNum).Append("\n");
            sb.Append("  otherNum: ").Append(OtherNum).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  selectNum: ").Append(SelectNum).Append("\n");
            sb.Append("  updateNum: ").Append(UpdateNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SQLStatisticsBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SQLStatisticsBean input)
        {
            if (input == null) return false;
            if (this.DeleteNum != input.DeleteNum || (this.DeleteNum != null && !this.DeleteNum.Equals(input.DeleteNum))) return false;
            if (this.InsertNum != input.InsertNum || (this.InsertNum != null && !this.InsertNum.Equals(input.InsertNum))) return false;
            if (this.OtherNum != input.OtherNum || (this.OtherNum != null && !this.OtherNum.Equals(input.OtherNum))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.SelectNum != input.SelectNum || (this.SelectNum != null && !this.SelectNum.Equals(input.SelectNum))) return false;
            if (this.UpdateNum != input.UpdateNum || (this.UpdateNum != null && !this.UpdateNum.Equals(input.UpdateNum))) return false;

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
                if (this.DeleteNum != null) hashCode = hashCode * 59 + this.DeleteNum.GetHashCode();
                if (this.InsertNum != null) hashCode = hashCode * 59 + this.InsertNum.GetHashCode();
                if (this.OtherNum != null) hashCode = hashCode * 59 + this.OtherNum.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.SelectNum != null) hashCode = hashCode * 59 + this.SelectNum.GetHashCode();
                if (this.UpdateNum != null) hashCode = hashCode * 59 + this.UpdateNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
