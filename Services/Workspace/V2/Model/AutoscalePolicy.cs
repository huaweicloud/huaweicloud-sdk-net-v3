using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 弹性伸缩策略。
    /// </summary>
    public class AutoscalePolicy 
    {
        /// <summary>
        /// 弹性伸缩类型，ACCESS_CREATED：接入时创建，AUTO_CREATED：弹性伸缩。
        /// </summary>
        /// <value>弹性伸缩类型，ACCESS_CREATED：接入时创建，AUTO_CREATED：弹性伸缩。</value>
        [JsonConverter(typeof(EnumClassConverter<AutoscaleTypeEnum>))]
        public class AutoscaleTypeEnum
        {
            /// <summary>
            /// Enum ACCESS_CREATED for value: ACCESS_CREATED
            /// </summary>
            public static readonly AutoscaleTypeEnum ACCESS_CREATED = new AutoscaleTypeEnum("ACCESS_CREATED");

            /// <summary>
            /// Enum AUTO_CREATED for value: AUTO_CREATED
            /// </summary>
            public static readonly AutoscaleTypeEnum AUTO_CREATED = new AutoscaleTypeEnum("AUTO_CREATED");

            private static readonly Dictionary<string, AutoscaleTypeEnum> StaticFields =
            new Dictionary<string, AutoscaleTypeEnum>()
            {
                { "ACCESS_CREATED", ACCESS_CREATED },
                { "AUTO_CREATED", AUTO_CREATED },
            };

            private string _value;

            public AutoscaleTypeEnum()
            {

            }

            public AutoscaleTypeEnum(string value)
            {
                _value = value;
            }

            public static AutoscaleTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AutoscaleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AutoscaleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AutoscaleTypeEnum a, AutoscaleTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(AutoscaleTypeEnum a, AutoscaleTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 弹性伸缩类型，ACCESS_CREATED：接入时创建，AUTO_CREATED：弹性伸缩。
        /// </summary>
        [JsonProperty("autoscale_type", NullValueHandling = NullValueHandling.Ignore)]
        public AutoscaleTypeEnum AutoscaleType { get; set; }
        /// <summary>
        /// 自动创建桌面上限。
        /// </summary>
        [JsonProperty("max_auto_created", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAutoCreated { get; set; }

        /// <summary>
        /// 空闲桌面低于多少时开始自动创建桌面。
        /// </summary>
        [JsonProperty("min_idle", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinIdle { get; set; }

        /// <summary>
        /// 一次自动创建桌面的数量。
        /// </summary>
        [JsonProperty("once_auto_created", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnceAutoCreated { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoscalePolicy {\n");
            sb.Append("  autoscaleType: ").Append(AutoscaleType).Append("\n");
            sb.Append("  maxAutoCreated: ").Append(MaxAutoCreated).Append("\n");
            sb.Append("  minIdle: ").Append(MinIdle).Append("\n");
            sb.Append("  onceAutoCreated: ").Append(OnceAutoCreated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoscalePolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoscalePolicy input)
        {
            if (input == null) return false;
            if (this.AutoscaleType != input.AutoscaleType) return false;
            if (this.MaxAutoCreated != input.MaxAutoCreated || (this.MaxAutoCreated != null && !this.MaxAutoCreated.Equals(input.MaxAutoCreated))) return false;
            if (this.MinIdle != input.MinIdle || (this.MinIdle != null && !this.MinIdle.Equals(input.MinIdle))) return false;
            if (this.OnceAutoCreated != input.OnceAutoCreated || (this.OnceAutoCreated != null && !this.OnceAutoCreated.Equals(input.OnceAutoCreated))) return false;

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
                hashCode = hashCode * 59 + this.AutoscaleType.GetHashCode();
                if (this.MaxAutoCreated != null) hashCode = hashCode * 59 + this.MaxAutoCreated.GetHashCode();
                if (this.MinIdle != null) hashCode = hashCode * 59 + this.MinIdle.GetHashCode();
                if (this.OnceAutoCreated != null) hashCode = hashCode * 59 + this.OnceAutoCreated.GetHashCode();
                return hashCode;
            }
        }
    }
}
