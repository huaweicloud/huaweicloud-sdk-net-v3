using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoObjectMaskingInference 
    {
        /// <summary>
        /// 擦除场景，可选车内或车外场景【inside,outside】
        /// </summary>
        /// <value>擦除场景，可选车内或车外场景【inside,outside】</value>
        [JsonConverter(typeof(EnumClassConverter<SceneTypeEnum>))]
        public class SceneTypeEnum
        {
            /// <summary>
            /// Enum INSIDE for value: inside
            /// </summary>
            public static readonly SceneTypeEnum INSIDE = new SceneTypeEnum("inside");

            /// <summary>
            /// Enum OUTSIDE for value: outside
            /// </summary>
            public static readonly SceneTypeEnum OUTSIDE = new SceneTypeEnum("outside");

            private static readonly Dictionary<string, SceneTypeEnum> StaticFields =
            new Dictionary<string, SceneTypeEnum>()
            {
                { "inside", INSIDE },
                { "outside", OUTSIDE },
            };

            private string _value;

            public SceneTypeEnum()
            {

            }

            public SceneTypeEnum(string value)
            {
                _value = value;
            }

            public static SceneTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SceneTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SceneTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SceneTypeEnum a, SceneTypeEnum b)
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

            public static bool operator !=(SceneTypeEnum a, SceneTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 透传客户信息
        /// </summary>
        [JsonProperty("pass_through", NullValueHandling = NullValueHandling.Ignore)]
        public string PassThrough { get; set; }

        /// <summary>
        /// 擦除场景，可选车内或车外场景【inside,outside】
        /// </summary>
        [JsonProperty("scene_type", NullValueHandling = NullValueHandling.Ignore)]
        public SceneTypeEnum SceneType { get; set; }
        /// <summary>
        /// 用户自定义产物名，无此项输入时，输出路径为{output结构体中指定输出path}/{task_id}/{task_id}.mp4；有此项输入时，输出路径为{output结构体中指定输出path}/{outcome_name}.mp4，自定义产物路径最多可定义5层文件夹目录。
        /// </summary>
        [JsonProperty("outcome_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OutcomeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoObjectMaskingInference {\n");
            sb.Append("  passThrough: ").Append(PassThrough).Append("\n");
            sb.Append("  sceneType: ").Append(SceneType).Append("\n");
            sb.Append("  outcomeName: ").Append(OutcomeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoObjectMaskingInference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoObjectMaskingInference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PassThrough == input.PassThrough ||
                    (this.PassThrough != null &&
                    this.PassThrough.Equals(input.PassThrough))
                ) && 
                (
                    this.SceneType == input.SceneType ||
                    (this.SceneType != null &&
                    this.SceneType.Equals(input.SceneType))
                ) && 
                (
                    this.OutcomeName == input.OutcomeName ||
                    (this.OutcomeName != null &&
                    this.OutcomeName.Equals(input.OutcomeName))
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
                if (this.PassThrough != null)
                    hashCode = hashCode * 59 + this.PassThrough.GetHashCode();
                if (this.SceneType != null)
                    hashCode = hashCode * 59 + this.SceneType.GetHashCode();
                if (this.OutcomeName != null)
                    hashCode = hashCode * 59 + this.OutcomeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
