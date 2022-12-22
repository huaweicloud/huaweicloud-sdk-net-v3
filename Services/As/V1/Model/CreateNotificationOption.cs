using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 配置伸缩组通知
    /// </summary>
    public class CreateNotificationOption 
    {
        /// <summary>
        /// Defines topicScene
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<TopicSceneEnum>))]
        public class TopicSceneEnum
        {
            /// <summary>
            /// Enum SCALING_UP for value: SCALING_UP
            /// </summary>
            public static readonly TopicSceneEnum SCALING_UP = new TopicSceneEnum("SCALING_UP");

            /// <summary>
            /// Enum SCALING_UP_FAIL for value: SCALING_UP_FAIL
            /// </summary>
            public static readonly TopicSceneEnum SCALING_UP_FAIL = new TopicSceneEnum("SCALING_UP_FAIL");

            /// <summary>
            /// Enum SCALING_DOWN for value: SCALING_DOWN
            /// </summary>
            public static readonly TopicSceneEnum SCALING_DOWN = new TopicSceneEnum("SCALING_DOWN");

            /// <summary>
            /// Enum SCALING_DOWN_FAIL for value: SCALING_DOWN_FAIL
            /// </summary>
            public static readonly TopicSceneEnum SCALING_DOWN_FAIL = new TopicSceneEnum("SCALING_DOWN_FAIL");

            /// <summary>
            /// Enum SCALING_GROUP_ABNORMAL for value: SCALING_GROUP_ABNORMAL
            /// </summary>
            public static readonly TopicSceneEnum SCALING_GROUP_ABNORMAL = new TopicSceneEnum("SCALING_GROUP_ABNORMAL");

            private static readonly Dictionary<string, TopicSceneEnum> StaticFields =
            new Dictionary<string, TopicSceneEnum>()
            {
                { "SCALING_UP", SCALING_UP },
                { "SCALING_UP_FAIL", SCALING_UP_FAIL },
                { "SCALING_DOWN", SCALING_DOWN },
                { "SCALING_DOWN_FAIL", SCALING_DOWN_FAIL },
                { "SCALING_GROUP_ABNORMAL", SCALING_GROUP_ABNORMAL },
            };

            private string _value;

            public TopicSceneEnum()
            {

            }

            public TopicSceneEnum(string value)
            {
                _value = value;
            }

            public static TopicSceneEnum FromValue(string value)
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

                if (this.Equals(obj as TopicSceneEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TopicSceneEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TopicSceneEnum a, TopicSceneEnum b)
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

            public static bool operator !=(TopicSceneEnum a, TopicSceneEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// SMN服务中Topic的唯一的资源标识。
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 通知场景，有以下五种类型。SCALING_UP：扩容成功。SCALING_UP_FAIL：扩容失败。SCALING_DOWN：减容成功。SCALING_DOWN_FAIL：减容失败。SCALING_GROUP_ABNORMAL：伸缩组发生异常
        /// </summary>
        [JsonProperty("topic_scene", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopicSceneEnum> TopicScene { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNotificationOption {\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  topicScene: ").Append(TopicScene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNotificationOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNotificationOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopicUrn == input.TopicUrn ||
                    (this.TopicUrn != null &&
                    this.TopicUrn.Equals(input.TopicUrn))
                ) && 
                (
                    this.TopicScene == input.TopicScene ||
                    this.TopicScene != null &&
                    input.TopicScene != null &&
                    this.TopicScene.SequenceEqual(input.TopicScene)
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
                if (this.TopicUrn != null)
                    hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.TopicScene != null)
                    hashCode = hashCode * 59 + this.TopicScene.GetHashCode();
                return hashCode;
            }
        }
    }
}
