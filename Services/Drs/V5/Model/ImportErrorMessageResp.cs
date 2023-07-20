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
    /// 导入失败详情响应体。
    /// </summary>
    public class ImportErrorMessageResp 
    {

        /// <summary>
        /// sheet名称。
        /// </summary>
        [JsonProperty("sheet_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SheetName { get; set; }

        /// <summary>
        /// 行号。
        /// </summary>
        [JsonProperty("row_rum", NullValueHandling = NullValueHandling.Ignore)]
        public string RowRum { get; set; }

        /// <summary>
        /// 字段值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportErrorMessageResp {\n");
            sb.Append("  sheetName: ").Append(SheetName).Append("\n");
            sb.Append("  rowRum: ").Append(RowRum).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportErrorMessageResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportErrorMessageResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SheetName == input.SheetName ||
                    (this.SheetName != null &&
                    this.SheetName.Equals(input.SheetName))
                ) && 
                (
                    this.RowRum == input.RowRum ||
                    (this.RowRum != null &&
                    this.RowRum.Equals(input.RowRum))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.SheetName != null)
                    hashCode = hashCode * 59 + this.SheetName.GetHashCode();
                if (this.RowRum != null)
                    hashCode = hashCode * 59 + this.RowRum.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
