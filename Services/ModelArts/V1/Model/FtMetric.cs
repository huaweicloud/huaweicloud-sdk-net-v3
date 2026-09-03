using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练指标结构体
    /// </summary>
    public class FtMetric 
    {

        /// <summary>
        /// 指标中文名称，如 训练指标、准确率，前端用作图例或列名
        /// </summary>
        [JsonProperty("name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string NameCn { get; set; }

        /// <summary>
        /// 指标英文名称，如 train_loss、val_accuracy，前端用作图例或列名
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 指标中文解释，如 训练指标，前端用作针对指标进行释义
        /// </summary>
        [JsonProperty("des_en", NullValueHandling = NullValueHandling.Ignore)]
        public string DesEn { get; set; }

        /// <summary>
        /// 指标英文解释，如 train loss，前端用作针对指标进行释义
        /// </summary>
        [JsonProperty("des_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string DesCn { get; set; }

        /// <summary>
        /// 指标绘图类型，可选 line（折线图）或 pie（饼图）、tabel（表格）、scalar（单值），可扩展 image 等
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 逻辑分组，如 training、validation、test，可扩展，用于前端分栏或过滤
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// 指定哪些数据点字段用于分组生成多个系列（如 [\&quot;layer\&quot;,\&quot;feature\&quot;]）
        /// </summary>
        [JsonProperty("group_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// 明确指定用作 X 轴的数据点字段名（如 \&quot;step\&quot;、\&quot;epoch\&quot;、\&quot;timestamp\&quot;）
        /// </summary>
        [JsonProperty("x_axis", NullValueHandling = NullValueHandling.Ignore)]
        public string XAxis { get; set; }

        /// <summary>
        /// 逻辑分组，如 表面loss，用于前端分组或过滤
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 单位，如 %、samples/sec，仅用于展示
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 数据点数组，严格按时间/步序升序排列
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Object Data { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FtMetric {\n");
            sb.Append("  nameCn: ").Append(NameCn).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  desEn: ").Append(DesEn).Append("\n");
            sb.Append("  desCn: ").Append(DesCn).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  groupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  xAxis: ").Append(XAxis).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FtMetric);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FtMetric input)
        {
            if (input == null) return false;
            if (this.NameCn != input.NameCn || (this.NameCn != null && !this.NameCn.Equals(input.NameCn))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.DesEn != input.DesEn || (this.DesEn != null && !this.DesEn.Equals(input.DesEn))) return false;
            if (this.DesCn != input.DesCn || (this.DesCn != null && !this.DesCn.Equals(input.DesCn))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Group != input.Group || (this.Group != null && !this.Group.Equals(input.Group))) return false;
            if (this.GroupBy != input.GroupBy || (this.GroupBy != null && input.GroupBy != null && !this.GroupBy.SequenceEqual(input.GroupBy))) return false;
            if (this.XAxis != input.XAxis || (this.XAxis != null && !this.XAxis.Equals(input.XAxis))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;

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
                if (this.NameCn != null) hashCode = hashCode * 59 + this.NameCn.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.DesEn != null) hashCode = hashCode * 59 + this.DesEn.GetHashCode();
                if (this.DesCn != null) hashCode = hashCode * 59 + this.DesCn.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Group != null) hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.GroupBy != null) hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.XAxis != null) hashCode = hashCode * 59 + this.XAxis.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }
}
