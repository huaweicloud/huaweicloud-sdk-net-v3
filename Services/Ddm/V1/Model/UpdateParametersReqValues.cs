using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 需要修改的DDM实例参数的集合。
    /// </summary>
    public class UpdateParametersReqValues 
    {
        /// <summary>
        /// DDM服务端字符集，如果需要存储emoji表情符号，请选择utf8mb4,并设置RDS字符集也为utf8mb4。修改DDM服务端字符集时，DDM服务端字符序必须同步修改为对应类型的值。
        /// </summary>
        /// <value>DDM服务端字符集，如果需要存储emoji表情符号，请选择utf8mb4,并设置RDS字符集也为utf8mb4。修改DDM服务端字符集时，DDM服务端字符序必须同步修改为对应类型的值。</value>
        [JsonConverter(typeof(EnumClassConverter<CharacterSetServerEnum>))]
        public class CharacterSetServerEnum
        {
            /// <summary>
            /// Enum GBK for value: gbk
            /// </summary>
            public static readonly CharacterSetServerEnum GBK = new CharacterSetServerEnum("gbk");

            /// <summary>
            /// Enum UTF8 for value: utf8
            /// </summary>
            public static readonly CharacterSetServerEnum UTF8 = new CharacterSetServerEnum("utf8");

            /// <summary>
            /// Enum UTF8MB4 for value: utf8mb4
            /// </summary>
            public static readonly CharacterSetServerEnum UTF8MB4 = new CharacterSetServerEnum("utf8mb4");

            private static readonly Dictionary<string, CharacterSetServerEnum> StaticFields =
            new Dictionary<string, CharacterSetServerEnum>()
            {
                { "gbk", GBK },
                { "utf8", UTF8 },
                { "utf8mb4", UTF8MB4 },
            };

            private string _value;

            public CharacterSetServerEnum()
            {

            }

            public CharacterSetServerEnum(string value)
            {
                _value = value;
            }

            public static CharacterSetServerEnum FromValue(string value)
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

                if (this.Equals(obj as CharacterSetServerEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CharacterSetServerEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CharacterSetServerEnum a, CharacterSetServerEnum b)
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

            public static bool operator !=(CharacterSetServerEnum a, CharacterSetServerEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// DDM服务端字符序。修改DDM服务端字符序时，DDM服务端字符集必须同步修改为对应类型的值。
        /// </summary>
        /// <value>DDM服务端字符序。修改DDM服务端字符序时，DDM服务端字符集必须同步修改为对应类型的值。</value>
        [JsonConverter(typeof(EnumClassConverter<CollationServerEnum>))]
        public class CollationServerEnum
        {
            /// <summary>
            /// Enum UTF8_UNICODE_CI for value: utf8_unicode_ci
            /// </summary>
            public static readonly CollationServerEnum UTF8_UNICODE_CI = new CollationServerEnum("utf8_unicode_ci");

            /// <summary>
            /// Enum UTF8_BIN for value: utf8_bin
            /// </summary>
            public static readonly CollationServerEnum UTF8_BIN = new CollationServerEnum("utf8_bin");

            /// <summary>
            /// Enum GBK_CHINESE_CI for value: gbk_chinese_ci
            /// </summary>
            public static readonly CollationServerEnum GBK_CHINESE_CI = new CollationServerEnum("gbk_chinese_ci");

            /// <summary>
            /// Enum GBK_BIN for value: gbk_bin
            /// </summary>
            public static readonly CollationServerEnum GBK_BIN = new CollationServerEnum("gbk_bin");

            /// <summary>
            /// Enum UTF8MB4_UNICODE_CI for value: utf8mb4_unicode_ci
            /// </summary>
            public static readonly CollationServerEnum UTF8MB4_UNICODE_CI = new CollationServerEnum("utf8mb4_unicode_ci");

            /// <summary>
            /// Enum UTF8MB4_BIN for value: utf8mb4_bin
            /// </summary>
            public static readonly CollationServerEnum UTF8MB4_BIN = new CollationServerEnum("utf8mb4_bin");

            private static readonly Dictionary<string, CollationServerEnum> StaticFields =
            new Dictionary<string, CollationServerEnum>()
            {
                { "utf8_unicode_ci", UTF8_UNICODE_CI },
                { "utf8_bin", UTF8_BIN },
                { "gbk_chinese_ci", GBK_CHINESE_CI },
                { "gbk_bin", GBK_BIN },
                { "utf8mb4_unicode_ci", UTF8MB4_UNICODE_CI },
                { "utf8mb4_bin", UTF8MB4_BIN },
            };

            private string _value;

            public CollationServerEnum()
            {

            }

            public CollationServerEnum(string value)
            {
                _value = value;
            }

            public static CollationServerEnum FromValue(string value)
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

                if (this.Equals(obj as CollationServerEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CollationServerEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CollationServerEnum a, CollationServerEnum b)
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

            public static bool operator !=(CollationServerEnum a, CollationServerEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 逻辑表扫描时的分片并发执行级别: DATA_NODE: 分库间并行扫描，同一分库内各分片串行扫描;RDS_INSTANCE: RDS实例间并行扫描，同一RDS实例内各分片串行扫描;PHY_TABLE: 各物理分片全部并行扫描。
        /// </summary>
        /// <value>逻辑表扫描时的分片并发执行级别: DATA_NODE: 分库间并行扫描，同一分库内各分片串行扫描;RDS_INSTANCE: RDS实例间并行扫描，同一RDS实例内各分片串行扫描;PHY_TABLE: 各物理分片全部并行扫描。</value>
        [JsonConverter(typeof(EnumClassConverter<ConcurrentExecutionLevelEnum>))]
        public class ConcurrentExecutionLevelEnum
        {
            /// <summary>
            /// Enum RDS_INSTANCE for value: RDS_INSTANCE
            /// </summary>
            public static readonly ConcurrentExecutionLevelEnum RDS_INSTANCE = new ConcurrentExecutionLevelEnum("RDS_INSTANCE");

            /// <summary>
            /// Enum DATA_NODE for value: DATA_NODE
            /// </summary>
            public static readonly ConcurrentExecutionLevelEnum DATA_NODE = new ConcurrentExecutionLevelEnum("DATA_NODE");

            /// <summary>
            /// Enum PHY_TABLE for value: PHY_TABLE
            /// </summary>
            public static readonly ConcurrentExecutionLevelEnum PHY_TABLE = new ConcurrentExecutionLevelEnum("PHY_TABLE");

            private static readonly Dictionary<string, ConcurrentExecutionLevelEnum> StaticFields =
            new Dictionary<string, ConcurrentExecutionLevelEnum>()
            {
                { "RDS_INSTANCE", RDS_INSTANCE },
                { "DATA_NODE", DATA_NODE },
                { "PHY_TABLE", PHY_TABLE },
            };

            private string _value;

            public ConcurrentExecutionLevelEnum()
            {

            }

            public ConcurrentExecutionLevelEnum(string value)
            {
                _value = value;
            }

            public static ConcurrentExecutionLevelEnum FromValue(string value)
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

                if (this.Equals(obj as ConcurrentExecutionLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConcurrentExecutionLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConcurrentExecutionLevelEnum a, ConcurrentExecutionLevelEnum b)
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

            public static bool operator !=(ConcurrentExecutionLevelEnum a, ConcurrentExecutionLevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否开启表回收站。
        /// </summary>
        /// <value>是否开启表回收站。</value>
        [JsonConverter(typeof(EnumClassConverter<EnableTableRecycleEnum>))]
        public class EnableTableRecycleEnum
        {
            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly EnableTableRecycleEnum OFF = new EnableTableRecycleEnum("OFF");

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly EnableTableRecycleEnum ON = new EnableTableRecycleEnum("ON");

            private static readonly Dictionary<string, EnableTableRecycleEnum> StaticFields =
            new Dictionary<string, EnableTableRecycleEnum>()
            {
                { "OFF", OFF },
                { "ON", ON },
            };

            private string _value;

            public EnableTableRecycleEnum()
            {

            }

            public EnableTableRecycleEnum(string value)
            {
                _value = value;
            }

            public static EnableTableRecycleEnum FromValue(string value)
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

                if (this.Equals(obj as EnableTableRecycleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EnableTableRecycleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EnableTableRecycleEnum a, EnableTableRecycleEnum b)
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

            public static bool operator !=(EnableTableRecycleEnum a, EnableTableRecycleEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// insert 常量值使用load data执行。
        /// </summary>
        /// <value>insert 常量值使用load data执行。</value>
        [JsonConverter(typeof(EnumClassConverter<InsertToLoadDataEnum>))]
        public class InsertToLoadDataEnum
        {
            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly InsertToLoadDataEnum OFF = new InsertToLoadDataEnum("OFF");

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly InsertToLoadDataEnum ON = new InsertToLoadDataEnum("ON");

            private static readonly Dictionary<string, InsertToLoadDataEnum> StaticFields =
            new Dictionary<string, InsertToLoadDataEnum>()
            {
                { "OFF", OFF },
                { "ON", ON },
            };

            private string _value;

            public InsertToLoadDataEnum()
            {

            }

            public InsertToLoadDataEnum(string value)
            {
                _value = value;
            }

            public static InsertToLoadDataEnum FromValue(string value)
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

                if (this.Equals(obj as InsertToLoadDataEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InsertToLoadDataEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InsertToLoadDataEnum a, InsertToLoadDataEnum b)
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

            public static bool operator !=(InsertToLoadDataEnum a, InsertToLoadDataEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否强制下推查询语句中不含from的语句。
        /// </summary>
        /// <value>是否强制下推查询语句中不含from的语句。</value>
        [JsonConverter(typeof(EnumClassConverter<NotFromPushdownEnum>))]
        public class NotFromPushdownEnum
        {
            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly NotFromPushdownEnum OFF = new NotFromPushdownEnum("OFF");

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly NotFromPushdownEnum ON = new NotFromPushdownEnum("ON");

            private static readonly Dictionary<string, NotFromPushdownEnum> StaticFields =
            new Dictionary<string, NotFromPushdownEnum>()
            {
                { "OFF", OFF },
                { "ON", ON },
            };

            private string _value;

            public NotFromPushdownEnum()
            {

            }

            public NotFromPushdownEnum(string value)
            {
                _value = value;
            }

            public static NotFromPushdownEnum FromValue(string value)
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

                if (this.Equals(obj as NotFromPushdownEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NotFromPushdownEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NotFromPushdownEnum a, NotFromPushdownEnum b)
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

            public static bool operator !=(NotFromPushdownEnum a, NotFromPushdownEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 开启或关闭SQL审计。
        /// </summary>
        /// <value>开启或关闭SQL审计。</value>
        [JsonConverter(typeof(EnumClassConverter<SqlAuditEnum>))]
        public class SqlAuditEnum
        {
            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly SqlAuditEnum OFF = new SqlAuditEnum("OFF");

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly SqlAuditEnum ON = new SqlAuditEnum("ON");

            private static readonly Dictionary<string, SqlAuditEnum> StaticFields =
            new Dictionary<string, SqlAuditEnum>()
            {
                { "OFF", OFF },
                { "ON", ON },
            };

            private string _value;

            public SqlAuditEnum()
            {

            }

            public SqlAuditEnum(string value)
            {
                _value = value;
            }

            public static SqlAuditEnum FromValue(string value)
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

                if (this.Equals(obj as SqlAuditEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SqlAuditEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SqlAuditEnum a, SqlAuditEnum b)
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

            public static bool operator !=(SqlAuditEnum a, SqlAuditEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// DDL语句添加binlog hint。
        /// </summary>
        /// <value>DDL语句添加binlog hint。</value>
        [JsonConverter(typeof(EnumClassConverter<SupportDdlBinlogHintEnum>))]
        public class SupportDdlBinlogHintEnum
        {
            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly SupportDdlBinlogHintEnum OFF = new SupportDdlBinlogHintEnum("OFF");

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly SupportDdlBinlogHintEnum ON = new SupportDdlBinlogHintEnum("ON");

            private static readonly Dictionary<string, SupportDdlBinlogHintEnum> StaticFields =
            new Dictionary<string, SupportDdlBinlogHintEnum>()
            {
                { "OFF", OFF },
                { "ON", ON },
            };

            private string _value;

            public SupportDdlBinlogHintEnum()
            {

            }

            public SupportDdlBinlogHintEnum(string value)
            {
                _value = value;
            }

            public static SupportDdlBinlogHintEnum FromValue(string value)
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

                if (this.Equals(obj as SupportDdlBinlogHintEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SupportDdlBinlogHintEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SupportDdlBinlogHintEnum a, SupportDdlBinlogHintEnum b)
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

            public static bool operator !=(SupportDdlBinlogHintEnum a, SupportDdlBinlogHintEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// XA：XA 事务，保证原子性，保证可见性；FREE：允许多写，不保证原子性，无性能损耗；NO_DTX：单分片事务。
        /// </summary>
        /// <value>XA：XA 事务，保证原子性，保证可见性；FREE：允许多写，不保证原子性，无性能损耗；NO_DTX：单分片事务。</value>
        [JsonConverter(typeof(EnumClassConverter<TransactionPolicyEnum>))]
        public class TransactionPolicyEnum
        {
            /// <summary>
            /// Enum XA for value: XA
            /// </summary>
            public static readonly TransactionPolicyEnum XA = new TransactionPolicyEnum("XA");

            /// <summary>
            /// Enum FREE for value: FREE
            /// </summary>
            public static readonly TransactionPolicyEnum FREE = new TransactionPolicyEnum("FREE");

            /// <summary>
            /// Enum NO_DTX for value: NO_DTX
            /// </summary>
            public static readonly TransactionPolicyEnum NO_DTX = new TransactionPolicyEnum("NO_DTX");

            private static readonly Dictionary<string, TransactionPolicyEnum> StaticFields =
            new Dictionary<string, TransactionPolicyEnum>()
            {
                { "XA", XA },
                { "FREE", FREE },
                { "NO_DTX", NO_DTX },
            };

            private string _value;

            public TransactionPolicyEnum()
            {

            }

            public TransactionPolicyEnum(string value)
            {
                _value = value;
            }

            public static TransactionPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as TransactionPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TransactionPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TransactionPolicyEnum a, TransactionPolicyEnum b)
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

            public static bool operator !=(TransactionPolicyEnum a, TransactionPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 开启或关闭优化器中的极致下推优化功能。
        /// </summary>
        /// <value>开启或关闭优化器中的极致下推优化功能。</value>
        [JsonConverter(typeof(EnumClassConverter<UltimateOptimizeEnum>))]
        public class UltimateOptimizeEnum
        {
            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly UltimateOptimizeEnum OFF = new UltimateOptimizeEnum("OFF");

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly UltimateOptimizeEnum ON = new UltimateOptimizeEnum("ON");

            private static readonly Dictionary<string, UltimateOptimizeEnum> StaticFields =
            new Dictionary<string, UltimateOptimizeEnum>()
            {
                { "OFF", OFF },
                { "ON", ON },
            };

            private string _value;

            public UltimateOptimizeEnum()
            {

            }

            public UltimateOptimizeEnum(string value)
            {
                _value = value;
            }

            public static UltimateOptimizeEnum FromValue(string value)
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

                if (this.Equals(obj as UltimateOptimizeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UltimateOptimizeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UltimateOptimizeEnum a, UltimateOptimizeEnum b)
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

            public static bool operator !=(UltimateOptimizeEnum a, UltimateOptimizeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用于描述多个拆分表的内在数据关联性，用于告知优化器在处理join时，把join下推到MySQL层执行。格式为:[{tb.col1,tb2.col2},{tb.col2,tb3.col1},...]。
        /// </summary>
        [JsonProperty("bind_table", NullValueHandling = NullValueHandling.Ignore)]
        public string BindTable { get; set; }

        /// <summary>
        /// DDM服务端字符集，如果需要存储emoji表情符号，请选择utf8mb4,并设置RDS字符集也为utf8mb4。修改DDM服务端字符集时，DDM服务端字符序必须同步修改为对应类型的值。
        /// </summary>
        [JsonProperty("character_set_server", NullValueHandling = NullValueHandling.Ignore)]
        public CharacterSetServerEnum CharacterSetServer { get; set; }
        /// <summary>
        /// DDM服务端字符序。修改DDM服务端字符序时，DDM服务端字符集必须同步修改为对应类型的值。
        /// </summary>
        [JsonProperty("collation_server", NullValueHandling = NullValueHandling.Ignore)]
        public CollationServerEnum CollationServer { get; set; }
        /// <summary>
        /// 逻辑表扫描时的分片并发执行级别: DATA_NODE: 分库间并行扫描，同一分库内各分片串行扫描;RDS_INSTANCE: RDS实例间并行扫描，同一RDS实例内各分片串行扫描;PHY_TABLE: 各物理分片全部并行扫描。
        /// </summary>
        [JsonProperty("concurrent_execution_level", NullValueHandling = NullValueHandling.Ignore)]
        public ConcurrentExecutionLevelEnum ConcurrentExecutionLevel { get; set; }
        /// <summary>
        /// 服务器关闭连接之前等待连接活动的秒数，以秒为单位，取值范围为60-28800，默认值28800，表示服务器关闭连接之前等待28800秒后，关闭连接。
        /// </summary>
        [JsonProperty("connection_idle_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionIdleTimeout { get; set; }

        /// <summary>
        /// 是否开启表回收站。
        /// </summary>
        [JsonProperty("enable_table_recycle", NullValueHandling = NullValueHandling.Ignore)]
        public EnableTableRecycleEnum EnableTableRecycle { get; set; }
        /// <summary>
        /// insert 常量值使用load data执行。
        /// </summary>
        [JsonProperty("insert_to_load_data", NullValueHandling = NullValueHandling.Ignore)]
        public InsertToLoadDataEnum InsertToLoadData { get; set; }
        /// <summary>
        /// 在途事务等待时间窗口，以秒为单位，取值范围为0-100，默认值为1，表示服务器关闭前端连接之前等待1秒后关闭连接。
        /// </summary>
        [JsonProperty("live_transaction_timeout_on_shutdown", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveTransactionTimeoutOnShutdown { get; set; }

        /// <summary>
        /// 记录慢查询的最小秒数,以秒为单位，取值范围为0.01-10，默认值为1，表示如果sql执行大于等于1秒就定义为慢sql。
        /// </summary>
        [JsonProperty("long_query_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LongQueryTime { get; set; }

        /// <summary>
        /// 包或任何生成的中间字符串的最大值。包缓冲区初始化为net_buffer_length字节，但需要时可以增长到max_allowed_packet字节。该值默认很小，以捕获大的（可能是错误的）数据包。该值必须设置为1024的倍数。取值范围为1024~1073741824，默认值为16777216。
        /// </summary>
        [JsonProperty("max_allowed_packet", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxAllowedPacket { get; set; }

        /// <summary>
        /// 允许每个DDM节点同时连接RDS的最大客户端总数。0为默认值标识符,实际值等于(RDS的最大连接数-20)/DDM节点数。取值范围为0-10000000。
        /// </summary>
        [JsonProperty("max_backend_connections", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxBackendConnections { get; set; }

        /// <summary>
        /// 允许同时连接的客户端总数。与后端RDS规格及数量有关。以个数为单位，取值范围为10-40000，默认值为20000，表示允许同时连接的客户端总数不能超过40000。
        /// </summary>
        [JsonProperty("max_connections", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConnections { get; set; }

        /// <summary>
        /// 允许每个DDM节点同时连接RDS的最小客户端总数。默认值为10。取值范围为0-10000000。
        /// </summary>
        [JsonProperty("min_backend_connections", NullValueHandling = NullValueHandling.Ignore)]
        public string MinBackendConnections { get; set; }

        /// <summary>
        /// 是否强制下推查询语句中不含from的语句。
        /// </summary>
        [JsonProperty("not_from_pushdown", NullValueHandling = NullValueHandling.Ignore)]
        public NotFromPushdownEnum NotFromPushdown { get; set; }
        /// <summary>
        /// 主从rds节点延迟时间阈值，以秒为单位，取值范围为0-7200，默认值为30，表示主rds与从rds之间的数据同步时间值不能超过30秒，如果超过30s，读数据指令就不走当前读节点。
        /// </summary>
        [JsonProperty("seconds_behind_master", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondsBehindMaster { get; set; }

        /// <summary>
        /// 开启或关闭SQL审计。
        /// </summary>
        [JsonProperty("sql_audit", NullValueHandling = NullValueHandling.Ignore)]
        public SqlAuditEnum SqlAudit { get; set; }
        /// <summary>
        /// SQL执行超时秒数，以秒为单位，取值范围为100-28800，默认值28800，表示sql执行大于等于28800秒超时。
        /// </summary>
        [JsonProperty("sql_execute_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlExecuteTimeout { get; set; }

        /// <summary>
        /// DDL语句添加binlog hint。
        /// </summary>
        [JsonProperty("support_ddl_binlog_hint", NullValueHandling = NullValueHandling.Ignore)]
        public SupportDdlBinlogHintEnum SupportDdlBinlogHint { get; set; }
        /// <summary>
        /// XA：XA 事务，保证原子性，保证可见性；FREE：允许多写，不保证原子性，无性能损耗；NO_DTX：单分片事务。
        /// </summary>
        [JsonProperty("transaction_policy", NullValueHandling = NullValueHandling.Ignore)]
        public TransactionPolicyEnum TransactionPolicy { get; set; }
        /// <summary>
        /// 开启或关闭优化器中的极致下推优化功能。
        /// </summary>
        [JsonProperty("ultimate_optimize", NullValueHandling = NullValueHandling.Ignore)]
        public UltimateOptimizeEnum UltimateOptimize { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateParametersReqValues {\n");
            sb.Append("  bindTable: ").Append(BindTable).Append("\n");
            sb.Append("  characterSetServer: ").Append(CharacterSetServer).Append("\n");
            sb.Append("  collationServer: ").Append(CollationServer).Append("\n");
            sb.Append("  concurrentExecutionLevel: ").Append(ConcurrentExecutionLevel).Append("\n");
            sb.Append("  connectionIdleTimeout: ").Append(ConnectionIdleTimeout).Append("\n");
            sb.Append("  enableTableRecycle: ").Append(EnableTableRecycle).Append("\n");
            sb.Append("  insertToLoadData: ").Append(InsertToLoadData).Append("\n");
            sb.Append("  liveTransactionTimeoutOnShutdown: ").Append(LiveTransactionTimeoutOnShutdown).Append("\n");
            sb.Append("  longQueryTime: ").Append(LongQueryTime).Append("\n");
            sb.Append("  maxAllowedPacket: ").Append(MaxAllowedPacket).Append("\n");
            sb.Append("  maxBackendConnections: ").Append(MaxBackendConnections).Append("\n");
            sb.Append("  maxConnections: ").Append(MaxConnections).Append("\n");
            sb.Append("  minBackendConnections: ").Append(MinBackendConnections).Append("\n");
            sb.Append("  notFromPushdown: ").Append(NotFromPushdown).Append("\n");
            sb.Append("  secondsBehindMaster: ").Append(SecondsBehindMaster).Append("\n");
            sb.Append("  sqlAudit: ").Append(SqlAudit).Append("\n");
            sb.Append("  sqlExecuteTimeout: ").Append(SqlExecuteTimeout).Append("\n");
            sb.Append("  supportDdlBinlogHint: ").Append(SupportDdlBinlogHint).Append("\n");
            sb.Append("  transactionPolicy: ").Append(TransactionPolicy).Append("\n");
            sb.Append("  ultimateOptimize: ").Append(UltimateOptimize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateParametersReqValues);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateParametersReqValues input)
        {
            if (input == null) return false;
            if (this.BindTable != input.BindTable || (this.BindTable != null && !this.BindTable.Equals(input.BindTable))) return false;
            if (this.CharacterSetServer != input.CharacterSetServer) return false;
            if (this.CollationServer != input.CollationServer) return false;
            if (this.ConcurrentExecutionLevel != input.ConcurrentExecutionLevel) return false;
            if (this.ConnectionIdleTimeout != input.ConnectionIdleTimeout || (this.ConnectionIdleTimeout != null && !this.ConnectionIdleTimeout.Equals(input.ConnectionIdleTimeout))) return false;
            if (this.EnableTableRecycle != input.EnableTableRecycle) return false;
            if (this.InsertToLoadData != input.InsertToLoadData) return false;
            if (this.LiveTransactionTimeoutOnShutdown != input.LiveTransactionTimeoutOnShutdown || (this.LiveTransactionTimeoutOnShutdown != null && !this.LiveTransactionTimeoutOnShutdown.Equals(input.LiveTransactionTimeoutOnShutdown))) return false;
            if (this.LongQueryTime != input.LongQueryTime || (this.LongQueryTime != null && !this.LongQueryTime.Equals(input.LongQueryTime))) return false;
            if (this.MaxAllowedPacket != input.MaxAllowedPacket || (this.MaxAllowedPacket != null && !this.MaxAllowedPacket.Equals(input.MaxAllowedPacket))) return false;
            if (this.MaxBackendConnections != input.MaxBackendConnections || (this.MaxBackendConnections != null && !this.MaxBackendConnections.Equals(input.MaxBackendConnections))) return false;
            if (this.MaxConnections != input.MaxConnections || (this.MaxConnections != null && !this.MaxConnections.Equals(input.MaxConnections))) return false;
            if (this.MinBackendConnections != input.MinBackendConnections || (this.MinBackendConnections != null && !this.MinBackendConnections.Equals(input.MinBackendConnections))) return false;
            if (this.NotFromPushdown != input.NotFromPushdown) return false;
            if (this.SecondsBehindMaster != input.SecondsBehindMaster || (this.SecondsBehindMaster != null && !this.SecondsBehindMaster.Equals(input.SecondsBehindMaster))) return false;
            if (this.SqlAudit != input.SqlAudit) return false;
            if (this.SqlExecuteTimeout != input.SqlExecuteTimeout || (this.SqlExecuteTimeout != null && !this.SqlExecuteTimeout.Equals(input.SqlExecuteTimeout))) return false;
            if (this.SupportDdlBinlogHint != input.SupportDdlBinlogHint) return false;
            if (this.TransactionPolicy != input.TransactionPolicy) return false;
            if (this.UltimateOptimize != input.UltimateOptimize) return false;

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
                if (this.BindTable != null) hashCode = hashCode * 59 + this.BindTable.GetHashCode();
                hashCode = hashCode * 59 + this.CharacterSetServer.GetHashCode();
                hashCode = hashCode * 59 + this.CollationServer.GetHashCode();
                hashCode = hashCode * 59 + this.ConcurrentExecutionLevel.GetHashCode();
                if (this.ConnectionIdleTimeout != null) hashCode = hashCode * 59 + this.ConnectionIdleTimeout.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTableRecycle.GetHashCode();
                hashCode = hashCode * 59 + this.InsertToLoadData.GetHashCode();
                if (this.LiveTransactionTimeoutOnShutdown != null) hashCode = hashCode * 59 + this.LiveTransactionTimeoutOnShutdown.GetHashCode();
                if (this.LongQueryTime != null) hashCode = hashCode * 59 + this.LongQueryTime.GetHashCode();
                if (this.MaxAllowedPacket != null) hashCode = hashCode * 59 + this.MaxAllowedPacket.GetHashCode();
                if (this.MaxBackendConnections != null) hashCode = hashCode * 59 + this.MaxBackendConnections.GetHashCode();
                if (this.MaxConnections != null) hashCode = hashCode * 59 + this.MaxConnections.GetHashCode();
                if (this.MinBackendConnections != null) hashCode = hashCode * 59 + this.MinBackendConnections.GetHashCode();
                hashCode = hashCode * 59 + this.NotFromPushdown.GetHashCode();
                if (this.SecondsBehindMaster != null) hashCode = hashCode * 59 + this.SecondsBehindMaster.GetHashCode();
                hashCode = hashCode * 59 + this.SqlAudit.GetHashCode();
                if (this.SqlExecuteTimeout != null) hashCode = hashCode * 59 + this.SqlExecuteTimeout.GetHashCode();
                hashCode = hashCode * 59 + this.SupportDdlBinlogHint.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.UltimateOptimize.GetHashCode();
                return hashCode;
            }
        }
    }
}
