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
    /// 诊断结果
    /// </summary>
    public class DiskSpaceDiagnosisResult 
    {

        /// <summary>
        /// **参数解释**：  诊断项编码。  **约束限制**：  不涉及。  **取值范围**：  - 1001（慢查询using filesort产生临时文件） - 1002（慢查询using temporary产生临时文件） - 1003（大事务产生binlog临时文件） - 1004（未使用ROW_FORMAT创建临时表） - 1005（使用ROW_FORMAT创建临时表） - 1006（Online DDL创建临时文件） - 1007（DDL产生临时日志） - 2001（长事务产生undo文件） - 2002（慢日志） - 2003（审计日志） - 2004（binlog） - 2005（relaylog） - 3001（数据文件） - 4001（执行时间长） - 4002（临时表类） - 4003（排序类） - 4004（DDL类）  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**：  诊断详情。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <summary>
        /// **参数解释**：  用户查询时间内的磁盘容量是否受该诊断项影响，1代表是，0代表否。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("affect", NullValueHandling = NullValueHandling.Ignore)]
        public int? Affect { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiskSpaceDiagnosisResult {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  affect: ").Append(Affect).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiskSpaceDiagnosisResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiskSpaceDiagnosisResult input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Detail != input.Detail || (this.Detail != null && !this.Detail.Equals(input.Detail))) return false;
            if (this.Affect != input.Affect || (this.Affect != null && !this.Affect.Equals(input.Affect))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Detail != null) hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Affect != null) hashCode = hashCode * 59 + this.Affect.GetHashCode();
                return hashCode;
            }
        }
    }
}
