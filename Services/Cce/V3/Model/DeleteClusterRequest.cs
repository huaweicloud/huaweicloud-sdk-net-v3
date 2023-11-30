using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteClusterRequest 
    {
        /// <summary>
        /// 是否删除SFS Turbo（极速文件存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        /// <value>是否删除SFS Turbo（极速文件存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteEfsEnum>))]
        public class DeleteEfsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteEfsEnum TRUE = new DeleteEfsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteEfsEnum BLOCK = new DeleteEfsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteEfsEnum TRY = new DeleteEfsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteEfsEnum FALSE = new DeleteEfsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteEfsEnum SKIP = new DeleteEfsEnum("skip");

            private static readonly Dictionary<string, DeleteEfsEnum> StaticFields =
            new Dictionary<string, DeleteEfsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteEfsEnum()
            {

            }

            public DeleteEfsEnum(string value)
            {
                _value = value;
            }

            public static DeleteEfsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteEfsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteEfsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteEfsEnum a, DeleteEfsEnum b)
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

            public static bool operator !=(DeleteEfsEnum a, DeleteEfsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除eni ports（原生弹性网卡）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)
        /// </summary>
        /// <value>是否删除eni ports（原生弹性网卡）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteEniEnum>))]
        public class DeleteEniEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteEniEnum TRUE = new DeleteEniEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteEniEnum BLOCK = new DeleteEniEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteEniEnum TRY = new DeleteEniEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteEniEnum FALSE = new DeleteEniEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteEniEnum SKIP = new DeleteEniEnum("skip");

            private static readonly Dictionary<string, DeleteEniEnum> StaticFields =
            new Dictionary<string, DeleteEniEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteEniEnum()
            {

            }

            public DeleteEniEnum(string value)
            {
                _value = value;
            }

            public static DeleteEniEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteEniEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteEniEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteEniEnum a, DeleteEniEnum b)
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

            public static bool operator !=(DeleteEniEnum a, DeleteEniEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除evs（云硬盘）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        /// <value>是否删除evs（云硬盘）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteEvsEnum>))]
        public class DeleteEvsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteEvsEnum TRUE = new DeleteEvsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteEvsEnum BLOCK = new DeleteEvsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteEvsEnum TRY = new DeleteEvsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteEvsEnum FALSE = new DeleteEvsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteEvsEnum SKIP = new DeleteEvsEnum("skip");

            private static readonly Dictionary<string, DeleteEvsEnum> StaticFields =
            new Dictionary<string, DeleteEvsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteEvsEnum()
            {

            }

            public DeleteEvsEnum(string value)
            {
                _value = value;
            }

            public static DeleteEvsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteEvsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteEvsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteEvsEnum a, DeleteEvsEnum b)
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

            public static bool operator !=(DeleteEvsEnum a, DeleteEvsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除elb（弹性负载均衡）等集群Service/Ingress相关资源。 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)
        /// </summary>
        /// <value>是否删除elb（弹性负载均衡）等集群Service/Ingress相关资源。 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteNetEnum>))]
        public class DeleteNetEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteNetEnum TRUE = new DeleteNetEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteNetEnum BLOCK = new DeleteNetEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteNetEnum TRY = new DeleteNetEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteNetEnum FALSE = new DeleteNetEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteNetEnum SKIP = new DeleteNetEnum("skip");

            private static readonly Dictionary<string, DeleteNetEnum> StaticFields =
            new Dictionary<string, DeleteNetEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteNetEnum()
            {

            }

            public DeleteNetEnum(string value)
            {
                _value = value;
            }

            public static DeleteNetEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteNetEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteNetEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteNetEnum a, DeleteNetEnum b)
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

            public static bool operator !=(DeleteNetEnum a, DeleteNetEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除obs（对象存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        /// <value>是否删除obs（对象存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteObsEnum>))]
        public class DeleteObsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteObsEnum TRUE = new DeleteObsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteObsEnum BLOCK = new DeleteObsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteObsEnum TRY = new DeleteObsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteObsEnum FALSE = new DeleteObsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteObsEnum SKIP = new DeleteObsEnum("skip");

            private static readonly Dictionary<string, DeleteObsEnum> StaticFields =
            new Dictionary<string, DeleteObsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteObsEnum()
            {

            }

            public DeleteObsEnum(string value)
            {
                _value = value;
            }

            public static DeleteObsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteObsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteObsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteObsEnum a, DeleteObsEnum b)
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

            public static bool operator !=(DeleteObsEnum a, DeleteObsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除sfs（文件存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        /// <value>是否删除sfs（文件存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteSfsEnum>))]
        public class DeleteSfsEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteSfsEnum TRUE = new DeleteSfsEnum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteSfsEnum BLOCK = new DeleteSfsEnum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteSfsEnum TRY = new DeleteSfsEnum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteSfsEnum FALSE = new DeleteSfsEnum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteSfsEnum SKIP = new DeleteSfsEnum("skip");

            private static readonly Dictionary<string, DeleteSfsEnum> StaticFields =
            new Dictionary<string, DeleteSfsEnum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteSfsEnum()
            {

            }

            public DeleteSfsEnum(string value)
            {
                _value = value;
            }

            public static DeleteSfsEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteSfsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteSfsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteSfsEnum a, DeleteSfsEnum b)
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

            public static bool operator !=(DeleteSfsEnum a, DeleteSfsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否删除sfs3.0（文件存储卷3.0）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        /// <value>是否删除sfs3.0（文件存储卷3.0）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteSfs30Enum>))]
        public class DeleteSfs30Enum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly DeleteSfs30Enum TRUE = new DeleteSfs30Enum("true");

            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly DeleteSfs30Enum BLOCK = new DeleteSfs30Enum("block");

            /// <summary>
            /// Enum TRY for value: try
            /// </summary>
            public static readonly DeleteSfs30Enum TRY = new DeleteSfs30Enum("try");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly DeleteSfs30Enum FALSE = new DeleteSfs30Enum("false");

            /// <summary>
            /// Enum SKIP for value: skip
            /// </summary>
            public static readonly DeleteSfs30Enum SKIP = new DeleteSfs30Enum("skip");

            private static readonly Dictionary<string, DeleteSfs30Enum> StaticFields =
            new Dictionary<string, DeleteSfs30Enum>()
            {
                { "true", TRUE },
                { "block", BLOCK },
                { "try", TRY },
                { "false", FALSE },
                { "skip", SKIP },
            };

            private string _value;

            public DeleteSfs30Enum()
            {

            }

            public DeleteSfs30Enum(string value)
            {
                _value = value;
            }

            public static DeleteSfs30Enum FromValue(string value)
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

                if (this.Equals(obj as DeleteSfs30Enum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteSfs30Enum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteSfs30Enum a, DeleteSfs30Enum b)
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

            public static bool operator !=(DeleteSfs30Enum a, DeleteSfs30Enum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否使用包周期集群删除参数预置模式（仅对包周期集群生效）。  需要和其他删除选项参数一起使用，未指定的参数，则使用默认值。  使用该参数，集群不执行真正的删除，仅将本次请求的全部query参数都预置到集群数据库中，用于包周期集群退订时识别用户要删除的资源。  允许重复执行，覆盖预置的删除参数。  枚举取值： - true  (预置模式，仅预置query参数，不执行删除)
        /// </summary>
        /// <value>是否使用包周期集群删除参数预置模式（仅对包周期集群生效）。  需要和其他删除选项参数一起使用，未指定的参数，则使用默认值。  使用该参数，集群不执行真正的删除，仅将本次请求的全部query参数都预置到集群数据库中，用于包周期集群退订时识别用户要删除的资源。  允许重复执行，覆盖预置的删除参数。  枚举取值： - true  (预置模式，仅预置query参数，不执行删除)</value>
        [JsonConverter(typeof(EnumClassConverter<TobedeletedEnum>))]
        public class TobedeletedEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly TobedeletedEnum TRUE = new TobedeletedEnum("true");

            private static readonly Dictionary<string, TobedeletedEnum> StaticFields =
            new Dictionary<string, TobedeletedEnum>()
            {
                { "true", TRUE },
            };

            private string _value;

            public TobedeletedEnum()
            {

            }

            public TobedeletedEnum(string value)
            {
                _value = value;
            }

            public static TobedeletedEnum FromValue(string value)
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

                if (this.Equals(obj as TobedeletedEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TobedeletedEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TobedeletedEnum a, TobedeletedEnum b)
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

            public static bool operator !=(TobedeletedEnum a, TobedeletedEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 集群下所有按需节点处理策略， 枚举取值： - delete (删除服务器) - reset (保留服务器并重置服务器，数据不保留) - retain （保留服务器不重置服务器，数据保留）
        /// </summary>
        /// <value>集群下所有按需节点处理策略， 枚举取值： - delete (删除服务器) - reset (保留服务器并重置服务器，数据不保留) - retain （保留服务器不重置服务器，数据保留）</value>
        [JsonConverter(typeof(EnumClassConverter<OndemandNodePolicyEnum>))]
        public class OndemandNodePolicyEnum
        {
            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly OndemandNodePolicyEnum DELETE = new OndemandNodePolicyEnum("delete");

            /// <summary>
            /// Enum RESET for value: reset
            /// </summary>
            public static readonly OndemandNodePolicyEnum RESET = new OndemandNodePolicyEnum("reset");

            /// <summary>
            /// Enum RETAIN for value: retain
            /// </summary>
            public static readonly OndemandNodePolicyEnum RETAIN = new OndemandNodePolicyEnum("retain");

            private static readonly Dictionary<string, OndemandNodePolicyEnum> StaticFields =
            new Dictionary<string, OndemandNodePolicyEnum>()
            {
                { "delete", DELETE },
                { "reset", RESET },
                { "retain", RETAIN },
            };

            private string _value;

            public OndemandNodePolicyEnum()
            {

            }

            public OndemandNodePolicyEnum(string value)
            {
                _value = value;
            }

            public static OndemandNodePolicyEnum FromValue(string value)
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

                if (this.Equals(obj as OndemandNodePolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OndemandNodePolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OndemandNodePolicyEnum a, OndemandNodePolicyEnum b)
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

            public static bool operator !=(OndemandNodePolicyEnum a, OndemandNodePolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 集群下所有包周期节点处理策略， 枚举取值： - reset (保留服务器并重置服务器，数据不保留) - retain （保留服务器不重置服务器，数据保留）
        /// </summary>
        /// <value>集群下所有包周期节点处理策略， 枚举取值： - reset (保留服务器并重置服务器，数据不保留) - retain （保留服务器不重置服务器，数据保留）</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodicNodePolicyEnum>))]
        public class PeriodicNodePolicyEnum
        {
            /// <summary>
            /// Enum RESET for value: reset
            /// </summary>
            public static readonly PeriodicNodePolicyEnum RESET = new PeriodicNodePolicyEnum("reset");

            /// <summary>
            /// Enum RETAIN for value: retain
            /// </summary>
            public static readonly PeriodicNodePolicyEnum RETAIN = new PeriodicNodePolicyEnum("retain");

            private static readonly Dictionary<string, PeriodicNodePolicyEnum> StaticFields =
            new Dictionary<string, PeriodicNodePolicyEnum>()
            {
                { "reset", RESET },
                { "retain", RETAIN },
            };

            private string _value;

            public PeriodicNodePolicyEnum()
            {

            }

            public PeriodicNodePolicyEnum(string value)
            {
                _value = value;
            }

            public static PeriodicNodePolicyEnum FromValue(string value)
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

                if (this.Equals(obj as PeriodicNodePolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodicNodePolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PeriodicNodePolicyEnum a, PeriodicNodePolicyEnum b)
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

            public static bool operator !=(PeriodicNodePolicyEnum a, PeriodicNodePolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 集群ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 是否删除SFS Turbo（极速文件存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        [SDKProperty("delete_efs", IsQuery = true)]
        [JsonProperty("delete_efs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteEfsEnum DeleteEfs { get; set; }
        /// <summary>
        /// 是否删除eni ports（原生弹性网卡）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)
        /// </summary>
        [SDKProperty("delete_eni", IsQuery = true)]
        [JsonProperty("delete_eni", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteEniEnum DeleteEni { get; set; }
        /// <summary>
        /// 是否删除evs（云硬盘）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        [SDKProperty("delete_evs", IsQuery = true)]
        [JsonProperty("delete_evs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteEvsEnum DeleteEvs { get; set; }
        /// <summary>
        /// 是否删除elb（弹性负载均衡）等集群Service/Ingress相关资源。 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程，默认选项) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程)
        /// </summary>
        [SDKProperty("delete_net", IsQuery = true)]
        [JsonProperty("delete_net", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteNetEnum DeleteNet { get; set; }
        /// <summary>
        /// 是否删除obs（对象存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        [SDKProperty("delete_obs", IsQuery = true)]
        [JsonProperty("delete_obs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteObsEnum DeleteObs { get; set; }
        /// <summary>
        /// 是否删除sfs（文件存储卷）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        [SDKProperty("delete_sfs", IsQuery = true)]
        [JsonProperty("delete_sfs", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteSfsEnum DeleteSfs { get; set; }
        /// <summary>
        /// 是否删除sfs3.0（文件存储卷3.0）， 枚举取值： - true或block (执行删除流程，失败则阻塞后续流程) - try (执行删除流程，失败则忽略，并继续执行后续流程) - false或skip (跳过删除流程，默认选项)
        /// </summary>
        [SDKProperty("delete_sfs30", IsQuery = true)]
        [JsonProperty("delete_sfs30", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteSfs30Enum DeleteSfs30 { get; set; }
        /// <summary>
        /// 是否使用包周期集群删除参数预置模式（仅对包周期集群生效）。  需要和其他删除选项参数一起使用，未指定的参数，则使用默认值。  使用该参数，集群不执行真正的删除，仅将本次请求的全部query参数都预置到集群数据库中，用于包周期集群退订时识别用户要删除的资源。  允许重复执行，覆盖预置的删除参数。  枚举取值： - true  (预置模式，仅预置query参数，不执行删除)
        /// </summary>
        [SDKProperty("tobedeleted", IsQuery = true)]
        [JsonProperty("tobedeleted", NullValueHandling = NullValueHandling.Ignore)]
        public TobedeletedEnum Tobedeleted { get; set; }
        /// <summary>
        /// 集群下所有按需节点处理策略， 枚举取值： - delete (删除服务器) - reset (保留服务器并重置服务器，数据不保留) - retain （保留服务器不重置服务器，数据保留）
        /// </summary>
        [SDKProperty("ondemand_node_policy", IsQuery = true)]
        [JsonProperty("ondemand_node_policy", NullValueHandling = NullValueHandling.Ignore)]
        public OndemandNodePolicyEnum OndemandNodePolicy { get; set; }
        /// <summary>
        /// 集群下所有包周期节点处理策略， 枚举取值： - reset (保留服务器并重置服务器，数据不保留) - retain （保留服务器不重置服务器，数据保留）
        /// </summary>
        [SDKProperty("periodic_node_policy", IsQuery = true)]
        [JsonProperty("periodic_node_policy", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodicNodePolicyEnum PeriodicNodePolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteClusterRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  deleteEfs: ").Append(DeleteEfs).Append("\n");
            sb.Append("  deleteEni: ").Append(DeleteEni).Append("\n");
            sb.Append("  deleteEvs: ").Append(DeleteEvs).Append("\n");
            sb.Append("  deleteNet: ").Append(DeleteNet).Append("\n");
            sb.Append("  deleteObs: ").Append(DeleteObs).Append("\n");
            sb.Append("  deleteSfs: ").Append(DeleteSfs).Append("\n");
            sb.Append("  deleteSfs30: ").Append(DeleteSfs30).Append("\n");
            sb.Append("  tobedeleted: ").Append(Tobedeleted).Append("\n");
            sb.Append("  ondemandNodePolicy: ").Append(OndemandNodePolicy).Append("\n");
            sb.Append("  periodicNodePolicy: ").Append(PeriodicNodePolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteClusterRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteClusterRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.DeleteEfs == input.DeleteEfs ||
                    (this.DeleteEfs != null &&
                    this.DeleteEfs.Equals(input.DeleteEfs))
                ) && 
                (
                    this.DeleteEni == input.DeleteEni ||
                    (this.DeleteEni != null &&
                    this.DeleteEni.Equals(input.DeleteEni))
                ) && 
                (
                    this.DeleteEvs == input.DeleteEvs ||
                    (this.DeleteEvs != null &&
                    this.DeleteEvs.Equals(input.DeleteEvs))
                ) && 
                (
                    this.DeleteNet == input.DeleteNet ||
                    (this.DeleteNet != null &&
                    this.DeleteNet.Equals(input.DeleteNet))
                ) && 
                (
                    this.DeleteObs == input.DeleteObs ||
                    (this.DeleteObs != null &&
                    this.DeleteObs.Equals(input.DeleteObs))
                ) && 
                (
                    this.DeleteSfs == input.DeleteSfs ||
                    (this.DeleteSfs != null &&
                    this.DeleteSfs.Equals(input.DeleteSfs))
                ) && 
                (
                    this.DeleteSfs30 == input.DeleteSfs30 ||
                    (this.DeleteSfs30 != null &&
                    this.DeleteSfs30.Equals(input.DeleteSfs30))
                ) && 
                (
                    this.Tobedeleted == input.Tobedeleted ||
                    (this.Tobedeleted != null &&
                    this.Tobedeleted.Equals(input.Tobedeleted))
                ) && 
                (
                    this.OndemandNodePolicy == input.OndemandNodePolicy ||
                    (this.OndemandNodePolicy != null &&
                    this.OndemandNodePolicy.Equals(input.OndemandNodePolicy))
                ) && 
                (
                    this.PeriodicNodePolicy == input.PeriodicNodePolicy ||
                    (this.PeriodicNodePolicy != null &&
                    this.PeriodicNodePolicy.Equals(input.PeriodicNodePolicy))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.DeleteEfs != null)
                    hashCode = hashCode * 59 + this.DeleteEfs.GetHashCode();
                if (this.DeleteEni != null)
                    hashCode = hashCode * 59 + this.DeleteEni.GetHashCode();
                if (this.DeleteEvs != null)
                    hashCode = hashCode * 59 + this.DeleteEvs.GetHashCode();
                if (this.DeleteNet != null)
                    hashCode = hashCode * 59 + this.DeleteNet.GetHashCode();
                if (this.DeleteObs != null)
                    hashCode = hashCode * 59 + this.DeleteObs.GetHashCode();
                if (this.DeleteSfs != null)
                    hashCode = hashCode * 59 + this.DeleteSfs.GetHashCode();
                if (this.DeleteSfs30 != null)
                    hashCode = hashCode * 59 + this.DeleteSfs30.GetHashCode();
                if (this.Tobedeleted != null)
                    hashCode = hashCode * 59 + this.Tobedeleted.GetHashCode();
                if (this.OndemandNodePolicy != null)
                    hashCode = hashCode * 59 + this.OndemandNodePolicy.GetHashCode();
                if (this.PeriodicNodePolicy != null)
                    hashCode = hashCode * 59 + this.PeriodicNodePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
