using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListWatermarkTemplateRequest 
    {
        /// <summary>
        /// 区分媒体直播还是云直播，默认云直播，默认查询cloud_live
        /// </summary>
        /// <value>区分媒体直播还是云直播，默认云直播，默认查询cloud_live</value>
        [JsonConverter(typeof(EnumClassConverter<SceneEnum>))]
        public class SceneEnum
        {
            /// <summary>
            /// Enum CLOUD_LIVE for value: cloud_live
            /// </summary>
            public static readonly SceneEnum CLOUD_LIVE = new SceneEnum("cloud_live");

            /// <summary>
            /// Enum MEDIA_LIVE for value: media_live
            /// </summary>
            public static readonly SceneEnum MEDIA_LIVE = new SceneEnum("media_live");

            private static readonly Dictionary<string, SceneEnum> StaticFields =
            new Dictionary<string, SceneEnum>()
            {
                { "cloud_live", CLOUD_LIVE },
                { "media_live", MEDIA_LIVE },
            };

            private string _value;

            public SceneEnum()
            {

            }

            public SceneEnum(string value)
            {
                _value = value;
            }

            public static SceneEnum FromValue(string value)
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

                if (this.Equals(obj as SceneEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SceneEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SceneEnum a, SceneEnum b)
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

            public static bool operator !=(SceneEnum a, SceneEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 水印模板名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 区分媒体直播还是云直播，默认云直播，默认查询cloud_live
        /// </summary>
        [SDKProperty("scene", IsQuery = true)]
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public SceneEnum Scene { get; set; }
        /// <summary>
        /// 偏移量，表示从此偏移量开始查询，offset大于等于0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页记录数，取值范围[1,100]，默认值10
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWatermarkTemplateRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWatermarkTemplateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWatermarkTemplateRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Scene != input.Scene) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
