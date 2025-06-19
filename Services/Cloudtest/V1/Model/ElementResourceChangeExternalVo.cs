using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 数据信息
    /// </summary>
    public class ElementResourceChangeExternalVo 
    {

        /// <summary>
        /// 工作项类型
        /// </summary>
        [JsonProperty("tracker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerName { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// key
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 对象值
        /// </summary>
        [JsonProperty("object_value", NullValueHandling = NullValueHandling.Ignore)]
        public Object ObjectValue { get; set; }

        /// <summary>
        /// 对象key
        /// </summary>
        [JsonProperty("object_key", NullValueHandling = NullValueHandling.Ignore)]
        public Object ObjectKey { get; set; }

        /// <summary>
        /// 缺陷类型
        /// </summary>
        [JsonProperty("tracker_names", NullValueHandling = NullValueHandling.Ignore)]
        public Object TrackerNames { get; set; }

        /// <summary>
        /// 归属看板信息，用例关联工作项信息使用
        /// </summary>
        [JsonProperty("board_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> BoardInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElementResourceChangeExternalVo {\n");
            sb.Append("  trackerName: ").Append(TrackerName).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  objectValue: ").Append(ObjectValue).Append("\n");
            sb.Append("  objectKey: ").Append(ObjectKey).Append("\n");
            sb.Append("  trackerNames: ").Append(TrackerNames).Append("\n");
            sb.Append("  boardInfo: ").Append(BoardInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ElementResourceChangeExternalVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ElementResourceChangeExternalVo input)
        {
            if (input == null) return false;
            if (this.TrackerName != input.TrackerName || (this.TrackerName != null && !this.TrackerName.Equals(input.TrackerName))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.ObjectValue != input.ObjectValue || (this.ObjectValue != null && !this.ObjectValue.Equals(input.ObjectValue))) return false;
            if (this.ObjectKey != input.ObjectKey || (this.ObjectKey != null && !this.ObjectKey.Equals(input.ObjectKey))) return false;
            if (this.TrackerNames != input.TrackerNames || (this.TrackerNames != null && !this.TrackerNames.Equals(input.TrackerNames))) return false;
            if (this.BoardInfo != input.BoardInfo || (this.BoardInfo != null && input.BoardInfo != null && !this.BoardInfo.SequenceEqual(input.BoardInfo))) return false;

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
                if (this.TrackerName != null) hashCode = hashCode * 59 + this.TrackerName.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ObjectValue != null) hashCode = hashCode * 59 + this.ObjectValue.GetHashCode();
                if (this.ObjectKey != null) hashCode = hashCode * 59 + this.ObjectKey.GetHashCode();
                if (this.TrackerNames != null) hashCode = hashCode * 59 + this.TrackerNames.GetHashCode();
                if (this.BoardInfo != null) hashCode = hashCode * 59 + this.BoardInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
