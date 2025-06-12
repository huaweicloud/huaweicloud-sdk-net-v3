using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 控制命令。
    /// </summary>
    public class ControlDigitalHumanLiveReq 
    {
        /// <summary>
        /// 命令名称。 - BODY_POS_RESET：视觉驱动复位 - HIPS_POS_ADJUST：模型位移调整 - EYE_POS：眼神锁定/解锁 - SKELETON_ROTATION_ADJUST：骨骼旋转 - LOCK_SKELETONS：骨骼锁定 - UNLOCK_SKELETONS：骨骼解锁
        /// </summary>
        /// <value>命令名称。 - BODY_POS_RESET：视觉驱动复位 - HIPS_POS_ADJUST：模型位移调整 - EYE_POS：眼神锁定/解锁 - SKELETON_ROTATION_ADJUST：骨骼旋转 - LOCK_SKELETONS：骨骼锁定 - UNLOCK_SKELETONS：骨骼解锁</value>
        [JsonConverter(typeof(EnumClassConverter<CommandEnum>))]
        public class CommandEnum
        {
            /// <summary>
            /// Enum BODY_POS_RESET for value: BODY_POS_RESET
            /// </summary>
            public static readonly CommandEnum BODY_POS_RESET = new CommandEnum("BODY_POS_RESET");

            /// <summary>
            /// Enum HIPS_POS_ADJUST for value: HIPS_POS_ADJUST
            /// </summary>
            public static readonly CommandEnum HIPS_POS_ADJUST = new CommandEnum("HIPS_POS_ADJUST");

            /// <summary>
            /// Enum EYE_POS for value: EYE_POS
            /// </summary>
            public static readonly CommandEnum EYE_POS = new CommandEnum("EYE_POS");

            /// <summary>
            /// Enum SKELETON_ROTATION_ADJUST for value: SKELETON_ROTATION_ADJUST
            /// </summary>
            public static readonly CommandEnum SKELETON_ROTATION_ADJUST = new CommandEnum("SKELETON_ROTATION_ADJUST");

            /// <summary>
            /// Enum LOCK_SKELETONS for value: LOCK_SKELETONS
            /// </summary>
            public static readonly CommandEnum LOCK_SKELETONS = new CommandEnum("LOCK_SKELETONS");

            /// <summary>
            /// Enum UNLOCK_SKELETONS for value: UNLOCK_SKELETONS
            /// </summary>
            public static readonly CommandEnum UNLOCK_SKELETONS = new CommandEnum("UNLOCK_SKELETONS");

            private static readonly Dictionary<string, CommandEnum> StaticFields =
            new Dictionary<string, CommandEnum>()
            {
                { "BODY_POS_RESET", BODY_POS_RESET },
                { "HIPS_POS_ADJUST", HIPS_POS_ADJUST },
                { "EYE_POS", EYE_POS },
                { "SKELETON_ROTATION_ADJUST", SKELETON_ROTATION_ADJUST },
                { "LOCK_SKELETONS", LOCK_SKELETONS },
                { "UNLOCK_SKELETONS", UNLOCK_SKELETONS },
            };

            private string _value;

            public CommandEnum()
            {

            }

            public CommandEnum(string value)
            {
                _value = value;
            }

            public static CommandEnum FromValue(string value)
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

                if (this.Equals(obj as CommandEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CommandEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CommandEnum a, CommandEnum b)
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

            public static bool operator !=(CommandEnum a, CommandEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 命令名称。 - BODY_POS_RESET：视觉驱动复位 - HIPS_POS_ADJUST：模型位移调整 - EYE_POS：眼神锁定/解锁 - SKELETON_ROTATION_ADJUST：骨骼旋转 - LOCK_SKELETONS：骨骼锁定 - UNLOCK_SKELETONS：骨骼解锁
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public CommandEnum Command { get; set; }
        /// <summary>
        /// 命令参数。
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public Object Params { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControlDigitalHumanLiveReq {\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ControlDigitalHumanLiveReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ControlDigitalHumanLiveReq input)
        {
            if (input == null) return false;
            if (this.Command != input.Command) return false;
            if (this.Params != input.Params || (this.Params != null && !this.Params.Equals(input.Params))) return false;

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
                hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }
    }
}
