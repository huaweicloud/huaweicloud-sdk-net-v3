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
    /// 表配置校验结果。
    /// </summary>
    public class TableConfigCheckResult 
    {

        /// <summary>
        /// 表名。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 表配置项。
        /// </summary>
        [JsonProperty("table_config", NullValueHandling = NullValueHandling.Ignore)]
        public string TableConfig { get; set; }

        /// <summary>
        /// 校验结果。
        /// </summary>
        [JsonProperty("check_result", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableConfigCheckResult {\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  tableConfig: ").Append(TableConfig).Append("\n");
            sb.Append("  checkResult: ").Append(CheckResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TableConfigCheckResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TableConfigCheckResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.TableConfig == input.TableConfig ||
                    (this.TableConfig != null &&
                    this.TableConfig.Equals(input.TableConfig))
                ) && 
                (
                    this.CheckResult == input.CheckResult ||
                    (this.CheckResult != null &&
                    this.CheckResult.Equals(input.CheckResult))
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
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.TableConfig != null)
                    hashCode = hashCode * 59 + this.TableConfig.GetHashCode();
                if (this.CheckResult != null)
                    hashCode = hashCode * 59 + this.CheckResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
