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
    /// Request Object
    /// </summary>
    public class ListAgenciesRequest 
    {
        /// <summary>
        /// 委托场景。 - WORKSPACE：云桌面。 - CLOUD_GAME：云游戏。 - CLOUD_STORAGE 云存储。 - SCREEN_RECORD：录屏审计。
        /// </summary>
        /// <value>委托场景。 - WORKSPACE：云桌面。 - CLOUD_GAME：云游戏。 - CLOUD_STORAGE 云存储。 - SCREEN_RECORD：录屏审计。</value>
        [JsonConverter(typeof(EnumClassConverter<SceneEnum>))]
        public class SceneEnum
        {
            /// <summary>
            /// Enum WORKSPACE for value: WORKSPACE
            /// </summary>
            public static readonly SceneEnum WORKSPACE = new SceneEnum("WORKSPACE");

            /// <summary>
            /// Enum CLOUD_GAME for value: CLOUD_GAME
            /// </summary>
            public static readonly SceneEnum CLOUD_GAME = new SceneEnum("CLOUD_GAME");

            /// <summary>
            /// Enum CLOUD_STORAGE for value: CLOUD_STORAGE
            /// </summary>
            public static readonly SceneEnum CLOUD_STORAGE = new SceneEnum("CLOUD_STORAGE");

            /// <summary>
            /// Enum SCREEN_RECORD for value: SCREEN_RECORD
            /// </summary>
            public static readonly SceneEnum SCREEN_RECORD = new SceneEnum("SCREEN_RECORD");

            private static readonly Dictionary<string, SceneEnum> StaticFields =
            new Dictionary<string, SceneEnum>()
            {
                { "WORKSPACE", WORKSPACE },
                { "CLOUD_GAME", CLOUD_GAME },
                { "CLOUD_STORAGE", CLOUD_STORAGE },
                { "SCREEN_RECORD", SCREEN_RECORD },
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

            public static bool operator !=(SceneEnum a, SceneEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 委托场景。 - WORKSPACE：云桌面。 - CLOUD_GAME：云游戏。 - CLOUD_STORAGE 云存储。 - SCREEN_RECORD：录屏审计。
        /// </summary>
        [SDKProperty("scene", IsQuery = true)]
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public SceneEnum Scene { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgenciesRequest {\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAgenciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgenciesRequest input)
        {
            if (input == null) return false;
            if (this.Scene != input.Scene) return false;

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
                hashCode = hashCode * 59 + this.Scene.GetHashCode();
                return hashCode;
            }
        }
    }
}
