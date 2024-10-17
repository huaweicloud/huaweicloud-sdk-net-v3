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
    /// 增量组件详情。
    /// </summary>
    public class IncreComponentDetail 
    {
        /// <summary>
        /// 组件类型 - capture：抓取 - apply：回放
        /// </summary>
        /// <value>组件类型 - capture：抓取 - apply：回放</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum CAPTURE for value: capture
            /// </summary>
            public static readonly TypeEnum CAPTURE = new TypeEnum("capture");

            /// <summary>
            /// Enum APPLY for value: apply
            /// </summary>
            public static readonly TypeEnum APPLY = new TypeEnum("apply");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "capture", CAPTURE },
                { "apply", APPLY },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 组件类型 - capture：抓取 - apply：回放
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 状态。 - STOPPED：停止 - STARTED：运行中 - STOPPING：停止中 - STARTING：启动中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 启动时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 启动位点
        /// </summary>
        [JsonProperty("start_point", NullValueHandling = NullValueHandling.Ignore)]
        public string StartPoint { get; set; }

        /// <summary>
        /// 当前位点
        /// </summary>
        [JsonProperty("current_point", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentPoint { get; set; }

        /// <summary>
        /// 解析时间
        /// </summary>
        [JsonProperty("resolution_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ResolutionTime { get; set; }

        /// <summary>
        /// 时延，单位：秒
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public string Delay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncreComponentDetail {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  startPoint: ").Append(StartPoint).Append("\n");
            sb.Append("  currentPoint: ").Append(CurrentPoint).Append("\n");
            sb.Append("  resolutionTime: ").Append(ResolutionTime).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IncreComponentDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IncreComponentDetail input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.StartPoint != input.StartPoint || (this.StartPoint != null && !this.StartPoint.Equals(input.StartPoint))) return false;
            if (this.CurrentPoint != input.CurrentPoint || (this.CurrentPoint != null && !this.CurrentPoint.Equals(input.CurrentPoint))) return false;
            if (this.ResolutionTime != input.ResolutionTime || (this.ResolutionTime != null && !this.ResolutionTime.Equals(input.ResolutionTime))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.StartPoint != null) hashCode = hashCode * 59 + this.StartPoint.GetHashCode();
                if (this.CurrentPoint != null) hashCode = hashCode * 59 + this.CurrentPoint.GetHashCode();
                if (this.ResolutionTime != null) hashCode = hashCode * 59 + this.ResolutionTime.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                return hashCode;
            }
        }
    }
}
