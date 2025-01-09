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
    /// 音频。
    /// </summary>
    public class PoliciesAudio 
    {
        /// <summary>
        /// 播音设置音量线性系数。取值为： 不设置：Do Not Set Volume Ratio。 低：Low。 中：Middle。 高：High。
        /// </summary>
        /// <value>播音设置音量线性系数。取值为： 不设置：Do Not Set Volume Ratio。 低：Low。 中：Middle。 高：High。</value>
        [JsonConverter(typeof(EnumClassConverter<PlayVolumeRatioEnum>))]
        public class PlayVolumeRatioEnum
        {
            /// <summary>
            /// Enum DO_NOT_SET_VOLUME_RATIO for value: Do Not Set Volume Ratio
            /// </summary>
            public static readonly PlayVolumeRatioEnum DO_NOT_SET_VOLUME_RATIO = new PlayVolumeRatioEnum("Do Not Set Volume Ratio");

            /// <summary>
            /// Enum LOW for value: Low
            /// </summary>
            public static readonly PlayVolumeRatioEnum LOW = new PlayVolumeRatioEnum("Low");

            /// <summary>
            /// Enum MIDDLE for value: Middle
            /// </summary>
            public static readonly PlayVolumeRatioEnum MIDDLE = new PlayVolumeRatioEnum("Middle");

            /// <summary>
            /// Enum HIGH for value: High
            /// </summary>
            public static readonly PlayVolumeRatioEnum HIGH = new PlayVolumeRatioEnum("High");

            private static readonly Dictionary<string, PlayVolumeRatioEnum> StaticFields =
            new Dictionary<string, PlayVolumeRatioEnum>()
            {
                { "Do Not Set Volume Ratio", DO_NOT_SET_VOLUME_RATIO },
                { "Low", LOW },
                { "Middle", MIDDLE },
                { "High", HIGH },
            };

            private string _value;

            public PlayVolumeRatioEnum()
            {

            }

            public PlayVolumeRatioEnum(string value)
            {
                _value = value;
            }

            public static PlayVolumeRatioEnum FromValue(string value)
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

                if (this.Equals(obj as PlayVolumeRatioEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayVolumeRatioEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayVolumeRatioEnum a, PlayVolumeRatioEnum b)
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

            public static bool operator !=(PlayVolumeRatioEnum a, PlayVolumeRatioEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 录音设置音量线性系数。取值为： 不设置：Do Not Set Volume Ratio。 低：Low。 中：Middle。 高：High。
        /// </summary>
        /// <value>录音设置音量线性系数。取值为： 不设置：Do Not Set Volume Ratio。 低：Low。 中：Middle。 高：High。</value>
        [JsonConverter(typeof(EnumClassConverter<RecordVolumeRatioEnum>))]
        public class RecordVolumeRatioEnum
        {
            /// <summary>
            /// Enum DO_NOT_SET_VOLUME_RATIO for value: Do Not Set Volume Ratio
            /// </summary>
            public static readonly RecordVolumeRatioEnum DO_NOT_SET_VOLUME_RATIO = new RecordVolumeRatioEnum("Do Not Set Volume Ratio");

            /// <summary>
            /// Enum LOW for value: Low
            /// </summary>
            public static readonly RecordVolumeRatioEnum LOW = new RecordVolumeRatioEnum("Low");

            /// <summary>
            /// Enum MIDDLE for value: Middle
            /// </summary>
            public static readonly RecordVolumeRatioEnum MIDDLE = new RecordVolumeRatioEnum("Middle");

            /// <summary>
            /// Enum HIGH for value: High
            /// </summary>
            public static readonly RecordVolumeRatioEnum HIGH = new RecordVolumeRatioEnum("High");

            private static readonly Dictionary<string, RecordVolumeRatioEnum> StaticFields =
            new Dictionary<string, RecordVolumeRatioEnum>()
            {
                { "Do Not Set Volume Ratio", DO_NOT_SET_VOLUME_RATIO },
                { "Low", LOW },
                { "Middle", MIDDLE },
                { "High", HIGH },
            };

            private string _value;

            public RecordVolumeRatioEnum()
            {

            }

            public RecordVolumeRatioEnum(string value)
            {
                _value = value;
            }

            public static RecordVolumeRatioEnum FromValue(string value)
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

                if (this.Equals(obj as RecordVolumeRatioEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordVolumeRatioEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordVolumeRatioEnum a, RecordVolumeRatioEnum b)
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

            public static bool operator !=(RecordVolumeRatioEnum a, RecordVolumeRatioEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 音频传输方式。取值为： 可靠传输：Reliable Transmission。 实时传输：Real Time Transmission。
        /// </summary>
        /// <value>音频传输方式。取值为： 可靠传输：Reliable Transmission。 实时传输：Real Time Transmission。</value>
        [JsonConverter(typeof(EnumClassConverter<AudioTransmissionModeEnum>))]
        public class AudioTransmissionModeEnum
        {
            /// <summary>
            /// Enum REAL_TIME_TRANSMISSION for value: Real Time Transmission
            /// </summary>
            public static readonly AudioTransmissionModeEnum REAL_TIME_TRANSMISSION = new AudioTransmissionModeEnum("Real Time Transmission");

            /// <summary>
            /// Enum RELIABLE_TRANSMISSION for value: Reliable Transmission
            /// </summary>
            public static readonly AudioTransmissionModeEnum RELIABLE_TRANSMISSION = new AudioTransmissionModeEnum("Reliable Transmission");

            private static readonly Dictionary<string, AudioTransmissionModeEnum> StaticFields =
            new Dictionary<string, AudioTransmissionModeEnum>()
            {
                { "Real Time Transmission", REAL_TIME_TRANSMISSION },
                { "Reliable Transmission", RELIABLE_TRANSMISSION },
            };

            private string _value;

            public AudioTransmissionModeEnum()
            {

            }

            public AudioTransmissionModeEnum(string value)
            {
                _value = value;
            }

            public static AudioTransmissionModeEnum FromValue(string value)
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

                if (this.Equals(obj as AudioTransmissionModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioTransmissionModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AudioTransmissionModeEnum a, AudioTransmissionModeEnum b)
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

            public static bool operator !=(AudioTransmissionModeEnum a, AudioTransmissionModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 播音场景。取值为： 无损播音：LossLess。 语音通话：Speech Call。 音乐播音：Music Play。 自动识别：Automatic Identification。
        /// </summary>
        /// <value>播音场景。取值为： 无损播音：LossLess。 语音通话：Speech Call。 音乐播音：Music Play。 自动识别：Automatic Identification。</value>
        [JsonConverter(typeof(EnumClassConverter<PlayClassificationEnum>))]
        public class PlayClassificationEnum
        {
            /// <summary>
            /// Enum LOSSLESS for value: LossLess
            /// </summary>
            public static readonly PlayClassificationEnum LOSSLESS = new PlayClassificationEnum("LossLess");

            /// <summary>
            /// Enum SPEECH_CALL for value: Speech Call
            /// </summary>
            public static readonly PlayClassificationEnum SPEECH_CALL = new PlayClassificationEnum("Speech Call");

            /// <summary>
            /// Enum MUSIC_PLAY for value: Music Play
            /// </summary>
            public static readonly PlayClassificationEnum MUSIC_PLAY = new PlayClassificationEnum("Music Play");

            /// <summary>
            /// Enum AUTOMATIC_IDENTIFICATION for value: Automatic Identification
            /// </summary>
            public static readonly PlayClassificationEnum AUTOMATIC_IDENTIFICATION = new PlayClassificationEnum("Automatic Identification");

            private static readonly Dictionary<string, PlayClassificationEnum> StaticFields =
            new Dictionary<string, PlayClassificationEnum>()
            {
                { "LossLess", LOSSLESS },
                { "Speech Call", SPEECH_CALL },
                { "Music Play", MUSIC_PLAY },
                { "Automatic Identification", AUTOMATIC_IDENTIFICATION },
            };

            private string _value;

            public PlayClassificationEnum()
            {

            }

            public PlayClassificationEnum(string value)
            {
                _value = value;
            }

            public static PlayClassificationEnum FromValue(string value)
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

                if (this.Equals(obj as PlayClassificationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayClassificationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayClassificationEnum a, PlayClassificationEnum b)
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

            public static bool operator !=(PlayClassificationEnum a, PlayClassificationEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 播音质量。取值为： 低：Low。 中：Middle。 高：High
        /// </summary>
        /// <value>播音质量。取值为： 低：Low。 中：Middle。 高：High</value>
        [JsonConverter(typeof(EnumClassConverter<PlayQualityEnum>))]
        public class PlayQualityEnum
        {
            /// <summary>
            /// Enum LOW for value: Low
            /// </summary>
            public static readonly PlayQualityEnum LOW = new PlayQualityEnum("Low");

            /// <summary>
            /// Enum MIDDLE for value: Middle
            /// </summary>
            public static readonly PlayQualityEnum MIDDLE = new PlayQualityEnum("Middle");

            /// <summary>
            /// Enum HIGH for value: High
            /// </summary>
            public static readonly PlayQualityEnum HIGH = new PlayQualityEnum("High");

            private static readonly Dictionary<string, PlayQualityEnum> StaticFields =
            new Dictionary<string, PlayQualityEnum>()
            {
                { "Low", LOW },
                { "Middle", MIDDLE },
                { "High", HIGH },
            };

            private string _value;

            public PlayQualityEnum()
            {

            }

            public PlayQualityEnum(string value)
            {
                _value = value;
            }

            public static PlayQualityEnum FromValue(string value)
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

                if (this.Equals(obj as PlayQualityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayQualityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayQualityEnum a, PlayQualityEnum b)
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

            public static bool operator !=(PlayQualityEnum a, PlayQualityEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 播音设置冗余。取值为： 不开启冗余：Disable CRC。 开启冗余：Enable CRC。
        /// </summary>
        /// <value>播音设置冗余。取值为： 不开启冗余：Disable CRC。 开启冗余：Enable CRC。</value>
        [JsonConverter(typeof(EnumClassConverter<PlayCrcEnum>))]
        public class PlayCrcEnum
        {
            /// <summary>
            /// Enum DISABLE_CRC for value: Disable CRC
            /// </summary>
            public static readonly PlayCrcEnum DISABLE_CRC = new PlayCrcEnum("Disable CRC");

            /// <summary>
            /// Enum ENABLE_CRC for value: Enable CRC
            /// </summary>
            public static readonly PlayCrcEnum ENABLE_CRC = new PlayCrcEnum("Enable CRC");

            private static readonly Dictionary<string, PlayCrcEnum> StaticFields =
            new Dictionary<string, PlayCrcEnum>()
            {
                { "Disable CRC", DISABLE_CRC },
                { "Enable CRC", ENABLE_CRC },
            };

            private string _value;

            public PlayCrcEnum()
            {

            }

            public PlayCrcEnum(string value)
            {
                _value = value;
            }

            public static PlayCrcEnum FromValue(string value)
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

                if (this.Equals(obj as PlayCrcEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayCrcEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayCrcEnum a, PlayCrcEnum b)
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

            public static bool operator !=(PlayCrcEnum a, PlayCrcEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 播音设置模式。取值为： 播音设备共享模式：Play Device In Shared Mode。 播音设备独占模式：Play Device In Exclusive Mode。
        /// </summary>
        /// <value>播音设置模式。取值为： 播音设备共享模式：Play Device In Shared Mode。 播音设备独占模式：Play Device In Exclusive Mode。</value>
        [JsonConverter(typeof(EnumClassConverter<PlayDeviceModeEnum>))]
        public class PlayDeviceModeEnum
        {
            /// <summary>
            /// Enum PLAY_DEVICE_IN_SHARED_MODE for value: Play Device In Shared Mode
            /// </summary>
            public static readonly PlayDeviceModeEnum PLAY_DEVICE_IN_SHARED_MODE = new PlayDeviceModeEnum("Play Device In Shared Mode");

            /// <summary>
            /// Enum PLAY_DEVICE_IN_EXCLUSIVE_MODE for value: Play Device In Exclusive Mode
            /// </summary>
            public static readonly PlayDeviceModeEnum PLAY_DEVICE_IN_EXCLUSIVE_MODE = new PlayDeviceModeEnum("Play Device In Exclusive Mode");

            private static readonly Dictionary<string, PlayDeviceModeEnum> StaticFields =
            new Dictionary<string, PlayDeviceModeEnum>()
            {
                { "Play Device In Shared Mode", PLAY_DEVICE_IN_SHARED_MODE },
                { "Play Device In Exclusive Mode", PLAY_DEVICE_IN_EXCLUSIVE_MODE },
            };

            private string _value;

            public PlayDeviceModeEnum()
            {

            }

            public PlayDeviceModeEnum(string value)
            {
                _value = value;
            }

            public static PlayDeviceModeEnum FromValue(string value)
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

                if (this.Equals(obj as PlayDeviceModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayDeviceModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayDeviceModeEnum a, PlayDeviceModeEnum b)
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

            public static bool operator !=(PlayDeviceModeEnum a, PlayDeviceModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 录音场景。取值为： 无损录音：LossLess。 语音通话：Speech Call。 音乐录音：Music Record。 自动识别：Automatic Identification。
        /// </summary>
        /// <value>录音场景。取值为： 无损录音：LossLess。 语音通话：Speech Call。 音乐录音：Music Record。 自动识别：Automatic Identification。</value>
        [JsonConverter(typeof(EnumClassConverter<RecordClassificationEnum>))]
        public class RecordClassificationEnum
        {
            /// <summary>
            /// Enum LOSSLESS for value: LossLess
            /// </summary>
            public static readonly RecordClassificationEnum LOSSLESS = new RecordClassificationEnum("LossLess");

            /// <summary>
            /// Enum SPEECH_CALL for value: Speech Call
            /// </summary>
            public static readonly RecordClassificationEnum SPEECH_CALL = new RecordClassificationEnum("Speech Call");

            /// <summary>
            /// Enum MUSIC_RECORD for value: Music Record
            /// </summary>
            public static readonly RecordClassificationEnum MUSIC_RECORD = new RecordClassificationEnum("Music Record");

            /// <summary>
            /// Enum AUTOMATIC_IDENTIFICATION for value: Automatic Identification
            /// </summary>
            public static readonly RecordClassificationEnum AUTOMATIC_IDENTIFICATION = new RecordClassificationEnum("Automatic Identification");

            private static readonly Dictionary<string, RecordClassificationEnum> StaticFields =
            new Dictionary<string, RecordClassificationEnum>()
            {
                { "LossLess", LOSSLESS },
                { "Speech Call", SPEECH_CALL },
                { "Music Record", MUSIC_RECORD },
                { "Automatic Identification", AUTOMATIC_IDENTIFICATION },
            };

            private string _value;

            public RecordClassificationEnum()
            {

            }

            public RecordClassificationEnum(string value)
            {
                _value = value;
            }

            public static RecordClassificationEnum FromValue(string value)
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

                if (this.Equals(obj as RecordClassificationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordClassificationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordClassificationEnum a, RecordClassificationEnum b)
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

            public static bool operator !=(RecordClassificationEnum a, RecordClassificationEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 录音质量。取值为： 低：Low。 中：Middle。 高：High。
        /// </summary>
        /// <value>录音质量。取值为： 低：Low。 中：Middle。 高：High。</value>
        [JsonConverter(typeof(EnumClassConverter<RecordQualityEnum>))]
        public class RecordQualityEnum
        {
            /// <summary>
            /// Enum LOW for value: Low
            /// </summary>
            public static readonly RecordQualityEnum LOW = new RecordQualityEnum("Low");

            /// <summary>
            /// Enum MIDDLE for value: Middle
            /// </summary>
            public static readonly RecordQualityEnum MIDDLE = new RecordQualityEnum("Middle");

            /// <summary>
            /// Enum HIGH for value: High
            /// </summary>
            public static readonly RecordQualityEnum HIGH = new RecordQualityEnum("High");

            private static readonly Dictionary<string, RecordQualityEnum> StaticFields =
            new Dictionary<string, RecordQualityEnum>()
            {
                { "Low", LOW },
                { "Middle", MIDDLE },
                { "High", HIGH },
            };

            private string _value;

            public RecordQualityEnum()
            {

            }

            public RecordQualityEnum(string value)
            {
                _value = value;
            }

            public static RecordQualityEnum FromValue(string value)
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

                if (this.Equals(obj as RecordQualityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordQualityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordQualityEnum a, RecordQualityEnum b)
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

            public static bool operator !=(RecordQualityEnum a, RecordQualityEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 录音设置冗余。取值为： 不开启冗余：Disable CRC。 开启冗余：Enable CRC。
        /// </summary>
        /// <value>录音设置冗余。取值为： 不开启冗余：Disable CRC。 开启冗余：Enable CRC。</value>
        [JsonConverter(typeof(EnumClassConverter<RecordCrcEnum>))]
        public class RecordCrcEnum
        {
            /// <summary>
            /// Enum DISABLE_CRC for value: Disable CRC
            /// </summary>
            public static readonly RecordCrcEnum DISABLE_CRC = new RecordCrcEnum("Disable CRC");

            /// <summary>
            /// Enum ENABLE_CRC for value: Enable CRC
            /// </summary>
            public static readonly RecordCrcEnum ENABLE_CRC = new RecordCrcEnum("Enable CRC");

            private static readonly Dictionary<string, RecordCrcEnum> StaticFields =
            new Dictionary<string, RecordCrcEnum>()
            {
                { "Disable CRC", DISABLE_CRC },
                { "Enable CRC", ENABLE_CRC },
            };

            private string _value;

            public RecordCrcEnum()
            {

            }

            public RecordCrcEnum(string value)
            {
                _value = value;
            }

            public static RecordCrcEnum FromValue(string value)
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

                if (this.Equals(obj as RecordCrcEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordCrcEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordCrcEnum a, RecordCrcEnum b)
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

            public static bool operator !=(RecordCrcEnum a, RecordCrcEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 录音设置模式。取值为： 播音设备共享模式：Record Device In Shared Mode。 播音设备独占模式：Record Device In Exclusive Mode。
        /// </summary>
        /// <value>录音设置模式。取值为： 播音设备共享模式：Record Device In Shared Mode。 播音设备独占模式：Record Device In Exclusive Mode。</value>
        [JsonConverter(typeof(EnumClassConverter<RecordDeviceModeEnum>))]
        public class RecordDeviceModeEnum
        {
            /// <summary>
            /// Enum RECORD_DEVICE_IN_SHARED_MODE for value: Record Device In Shared Mode
            /// </summary>
            public static readonly RecordDeviceModeEnum RECORD_DEVICE_IN_SHARED_MODE = new RecordDeviceModeEnum("Record Device In Shared Mode");

            /// <summary>
            /// Enum RECORD_DEVICE_IN_EXCLUSIVE_MODE for value: Record Device In Exclusive Mode
            /// </summary>
            public static readonly RecordDeviceModeEnum RECORD_DEVICE_IN_EXCLUSIVE_MODE = new RecordDeviceModeEnum("Record Device In Exclusive Mode");

            private static readonly Dictionary<string, RecordDeviceModeEnum> StaticFields =
            new Dictionary<string, RecordDeviceModeEnum>()
            {
                { "Record Device In Shared Mode", RECORD_DEVICE_IN_SHARED_MODE },
                { "Record Device In Exclusive Mode", RECORD_DEVICE_IN_EXCLUSIVE_MODE },
            };

            private string _value;

            public RecordDeviceModeEnum()
            {

            }

            public RecordDeviceModeEnum(string value)
            {
                _value = value;
            }

            public static RecordDeviceModeEnum FromValue(string value)
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

                if (this.Equals(obj as RecordDeviceModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordDeviceModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecordDeviceModeEnum a, RecordDeviceModeEnum b)
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

            public static bool operator !=(RecordDeviceModeEnum a, RecordDeviceModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否开启音频重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("audio_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AudioRedirectionEnable { get; set; }

        /// <summary>
        /// 播音设置音量。 不设置音量取值为：Do Not Set Volume。 音量设置，最小值为10，最大值为100，中间取值，间隔为5的递增序列。如：10、15、20、25等。
        /// </summary>
        [JsonProperty("play_volume", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayVolume { get; set; }

        /// <summary>
        /// 播音设置音量线性系数。取值为： 不设置：Do Not Set Volume Ratio。 低：Low。 中：Middle。 高：High。
        /// </summary>
        [JsonProperty("play_volume_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public PlayVolumeRatioEnum PlayVolumeRatio { get; set; }
        /// <summary>
        /// 录音设置音量。 不设置取值为：Do Not Set Volume。 音量设置，最小值为10，最大值为100，中间取值，间隔为5的递增序列。如：10、15、20、25等。
        /// </summary>
        [JsonProperty("record_volume", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordVolume { get; set; }

        /// <summary>
        /// 录音设置音量线性系数。取值为： 不设置：Do Not Set Volume Ratio。 低：Low。 中：Middle。 高：High。
        /// </summary>
        [JsonProperty("record_volume_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public RecordVolumeRatioEnum RecordVolumeRatio { get; set; }
        /// <summary>
        /// 音频传输方式。取值为： 可靠传输：Reliable Transmission。 实时传输：Real Time Transmission。
        /// </summary>
        [JsonProperty("audio_transmission_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AudioTransmissionModeEnum AudioTransmissionMode { get; set; }
        /// <summary>
        /// 是否开启播音重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("play_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PlayRedirectionEnable { get; set; }

        /// <summary>
        /// 播音场景。取值为： 无损播音：LossLess。 语音通话：Speech Call。 音乐播音：Music Play。 自动识别：Automatic Identification。
        /// </summary>
        [JsonProperty("play_classification", NullValueHandling = NullValueHandling.Ignore)]
        public PlayClassificationEnum PlayClassification { get; set; }
        /// <summary>
        /// 播音质量。取值为： 低：Low。 中：Middle。 高：High
        /// </summary>
        [JsonProperty("play_quality", NullValueHandling = NullValueHandling.Ignore)]
        public PlayQualityEnum PlayQuality { get; set; }
        /// <summary>
        /// 播音降噪。取值为： 不开启降噪：Disable Denoising。 开启降噪，最小值为-100，最大值为-5，中间取值，间隔为5的递增序列。如：-100、-95、-90、-85等。
        /// </summary>
        [JsonProperty("play_denoising", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDenoising { get; set; }

        /// <summary>
        /// 播音增益。取值为：不开启增益：Disable AGC。开启增益，最小值为4000，最大值为32000，中间取值，从10000开始间隔为1000的递增序列。如：4000、6000、8000、10000、11000、12000、13000等。
        /// </summary>
        [JsonProperty("play_agc", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayAgc { get; set; }

        /// <summary>
        /// 播音设置冗余。取值为： 不开启冗余：Disable CRC。 开启冗余：Enable CRC。
        /// </summary>
        [JsonProperty("play_crc", NullValueHandling = NullValueHandling.Ignore)]
        public PlayCrcEnum PlayCrc { get; set; }
        /// <summary>
        /// 播音设置模式。取值为： 播音设备共享模式：Play Device In Shared Mode。 播音设备独占模式：Play Device In Exclusive Mode。
        /// </summary>
        [JsonProperty("play_device_mode", NullValueHandling = NullValueHandling.Ignore)]
        public PlayDeviceModeEnum PlayDeviceMode { get; set; }
        /// <summary>
        /// 播音控制时延阈值。取值为：最小值为160，最大值为2500。中间取值，400以下为40的递增序列，1000以下为50的递增序列。从高到低为：2500、2000、1800、1500、1200、1000、950、900、850等。
        /// </summary>
        [JsonProperty("play_delay_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDelayThreshold { get; set; }

        /// <summary>
        /// 播音检测振幅阈值。取值为：2048、4096、5120、6144、7168、8192。
        /// </summary>
        [JsonProperty("play_amplitude_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayAmplitudeThreshold { get; set; }

        /// <summary>
        /// 播音音乐预充数据。取值为：不预充：Do Not Prefill Data。预充取值：最小值为50，最大值为2000，250以前为50的递增序列，500以前为100的递增序列。从高到低取值如：2000、1500、1000、500、400、300、250。
        /// </summary>
        [JsonProperty("play_prefill_data", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayPrefillData { get; set; }

        /// <summary>
        /// 是否开启录音重定向。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("record_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecordRedirectionEnable { get; set; }

        /// <summary>
        /// 录音场景。取值为： 无损录音：LossLess。 语音通话：Speech Call。 音乐录音：Music Record。 自动识别：Automatic Identification。
        /// </summary>
        [JsonProperty("record_classification", NullValueHandling = NullValueHandling.Ignore)]
        public RecordClassificationEnum RecordClassification { get; set; }
        /// <summary>
        /// 录音质量。取值为： 低：Low。 中：Middle。 高：High。
        /// </summary>
        [JsonProperty("record_quality", NullValueHandling = NullValueHandling.Ignore)]
        public RecordQualityEnum RecordQuality { get; set; }
        /// <summary>
        /// 录音降噪。取值为： 不开启降噪：Disable Denoising。 开启降噪，最小值为-100，最大值为-5，中间取值，间隔为5的递增序列。如：-100、-95、-90、-85等。
        /// </summary>
        [JsonProperty("record_denoising", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordDenoising { get; set; }

        /// <summary>
        /// 录音增益。取值为：不开启增益：Disable AGC。开启增益，最小值为4000，最大值为32000，中间取值，从10000开始间隔为1000的递增序列。如：4000、6000、8000、10000、11000、12000、13000等。
        /// </summary>
        [JsonProperty("record_agc", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordAgc { get; set; }

        /// <summary>
        /// 录音设置冗余。取值为： 不开启冗余：Disable CRC。 开启冗余：Enable CRC。
        /// </summary>
        [JsonProperty("record_crc", NullValueHandling = NullValueHandling.Ignore)]
        public RecordCrcEnum RecordCrc { get; set; }
        /// <summary>
        /// 录音设置模式。取值为： 播音设备共享模式：Record Device In Shared Mode。 播音设备独占模式：Record Device In Exclusive Mode。
        /// </summary>
        [JsonProperty("record_device_mode", NullValueHandling = NullValueHandling.Ignore)]
        public RecordDeviceModeEnum RecordDeviceMode { get; set; }
        /// <summary>
        /// 录音控制时延阈值。取值为：最小值为160，最大值为2500。中间取值，400以下为40的递增序列，1000以下为50的递增序列。从高到低为：2500、2000、1800、1500、1200、1000、950、900、850等。
        /// </summary>
        [JsonProperty("record_delay_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordDelayThreshold { get; set; }

        /// <summary>
        /// 录音检测振幅阈值。取值为：2048、4096、5120、6144、7168、8192。
        /// </summary>
        [JsonProperty("record_amplitude_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordAmplitudeThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesAudio {\n");
            sb.Append("  audioRedirectionEnable: ").Append(AudioRedirectionEnable).Append("\n");
            sb.Append("  playVolume: ").Append(PlayVolume).Append("\n");
            sb.Append("  playVolumeRatio: ").Append(PlayVolumeRatio).Append("\n");
            sb.Append("  recordVolume: ").Append(RecordVolume).Append("\n");
            sb.Append("  recordVolumeRatio: ").Append(RecordVolumeRatio).Append("\n");
            sb.Append("  audioTransmissionMode: ").Append(AudioTransmissionMode).Append("\n");
            sb.Append("  playRedirectionEnable: ").Append(PlayRedirectionEnable).Append("\n");
            sb.Append("  playClassification: ").Append(PlayClassification).Append("\n");
            sb.Append("  playQuality: ").Append(PlayQuality).Append("\n");
            sb.Append("  playDenoising: ").Append(PlayDenoising).Append("\n");
            sb.Append("  playAgc: ").Append(PlayAgc).Append("\n");
            sb.Append("  playCrc: ").Append(PlayCrc).Append("\n");
            sb.Append("  playDeviceMode: ").Append(PlayDeviceMode).Append("\n");
            sb.Append("  playDelayThreshold: ").Append(PlayDelayThreshold).Append("\n");
            sb.Append("  playAmplitudeThreshold: ").Append(PlayAmplitudeThreshold).Append("\n");
            sb.Append("  playPrefillData: ").Append(PlayPrefillData).Append("\n");
            sb.Append("  recordRedirectionEnable: ").Append(RecordRedirectionEnable).Append("\n");
            sb.Append("  recordClassification: ").Append(RecordClassification).Append("\n");
            sb.Append("  recordQuality: ").Append(RecordQuality).Append("\n");
            sb.Append("  recordDenoising: ").Append(RecordDenoising).Append("\n");
            sb.Append("  recordAgc: ").Append(RecordAgc).Append("\n");
            sb.Append("  recordCrc: ").Append(RecordCrc).Append("\n");
            sb.Append("  recordDeviceMode: ").Append(RecordDeviceMode).Append("\n");
            sb.Append("  recordDelayThreshold: ").Append(RecordDelayThreshold).Append("\n");
            sb.Append("  recordAmplitudeThreshold: ").Append(RecordAmplitudeThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesAudio);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesAudio input)
        {
            if (input == null) return false;
            if (this.AudioRedirectionEnable != input.AudioRedirectionEnable || (this.AudioRedirectionEnable != null && !this.AudioRedirectionEnable.Equals(input.AudioRedirectionEnable))) return false;
            if (this.PlayVolume != input.PlayVolume || (this.PlayVolume != null && !this.PlayVolume.Equals(input.PlayVolume))) return false;
            if (this.PlayVolumeRatio != input.PlayVolumeRatio) return false;
            if (this.RecordVolume != input.RecordVolume || (this.RecordVolume != null && !this.RecordVolume.Equals(input.RecordVolume))) return false;
            if (this.RecordVolumeRatio != input.RecordVolumeRatio) return false;
            if (this.AudioTransmissionMode != input.AudioTransmissionMode) return false;
            if (this.PlayRedirectionEnable != input.PlayRedirectionEnable || (this.PlayRedirectionEnable != null && !this.PlayRedirectionEnable.Equals(input.PlayRedirectionEnable))) return false;
            if (this.PlayClassification != input.PlayClassification) return false;
            if (this.PlayQuality != input.PlayQuality) return false;
            if (this.PlayDenoising != input.PlayDenoising || (this.PlayDenoising != null && !this.PlayDenoising.Equals(input.PlayDenoising))) return false;
            if (this.PlayAgc != input.PlayAgc || (this.PlayAgc != null && !this.PlayAgc.Equals(input.PlayAgc))) return false;
            if (this.PlayCrc != input.PlayCrc) return false;
            if (this.PlayDeviceMode != input.PlayDeviceMode) return false;
            if (this.PlayDelayThreshold != input.PlayDelayThreshold || (this.PlayDelayThreshold != null && !this.PlayDelayThreshold.Equals(input.PlayDelayThreshold))) return false;
            if (this.PlayAmplitudeThreshold != input.PlayAmplitudeThreshold || (this.PlayAmplitudeThreshold != null && !this.PlayAmplitudeThreshold.Equals(input.PlayAmplitudeThreshold))) return false;
            if (this.PlayPrefillData != input.PlayPrefillData || (this.PlayPrefillData != null && !this.PlayPrefillData.Equals(input.PlayPrefillData))) return false;
            if (this.RecordRedirectionEnable != input.RecordRedirectionEnable || (this.RecordRedirectionEnable != null && !this.RecordRedirectionEnable.Equals(input.RecordRedirectionEnable))) return false;
            if (this.RecordClassification != input.RecordClassification) return false;
            if (this.RecordQuality != input.RecordQuality) return false;
            if (this.RecordDenoising != input.RecordDenoising || (this.RecordDenoising != null && !this.RecordDenoising.Equals(input.RecordDenoising))) return false;
            if (this.RecordAgc != input.RecordAgc || (this.RecordAgc != null && !this.RecordAgc.Equals(input.RecordAgc))) return false;
            if (this.RecordCrc != input.RecordCrc) return false;
            if (this.RecordDeviceMode != input.RecordDeviceMode) return false;
            if (this.RecordDelayThreshold != input.RecordDelayThreshold || (this.RecordDelayThreshold != null && !this.RecordDelayThreshold.Equals(input.RecordDelayThreshold))) return false;
            if (this.RecordAmplitudeThreshold != input.RecordAmplitudeThreshold || (this.RecordAmplitudeThreshold != null && !this.RecordAmplitudeThreshold.Equals(input.RecordAmplitudeThreshold))) return false;

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
                if (this.AudioRedirectionEnable != null) hashCode = hashCode * 59 + this.AudioRedirectionEnable.GetHashCode();
                if (this.PlayVolume != null) hashCode = hashCode * 59 + this.PlayVolume.GetHashCode();
                hashCode = hashCode * 59 + this.PlayVolumeRatio.GetHashCode();
                if (this.RecordVolume != null) hashCode = hashCode * 59 + this.RecordVolume.GetHashCode();
                hashCode = hashCode * 59 + this.RecordVolumeRatio.GetHashCode();
                hashCode = hashCode * 59 + this.AudioTransmissionMode.GetHashCode();
                if (this.PlayRedirectionEnable != null) hashCode = hashCode * 59 + this.PlayRedirectionEnable.GetHashCode();
                hashCode = hashCode * 59 + this.PlayClassification.GetHashCode();
                hashCode = hashCode * 59 + this.PlayQuality.GetHashCode();
                if (this.PlayDenoising != null) hashCode = hashCode * 59 + this.PlayDenoising.GetHashCode();
                if (this.PlayAgc != null) hashCode = hashCode * 59 + this.PlayAgc.GetHashCode();
                hashCode = hashCode * 59 + this.PlayCrc.GetHashCode();
                hashCode = hashCode * 59 + this.PlayDeviceMode.GetHashCode();
                if (this.PlayDelayThreshold != null) hashCode = hashCode * 59 + this.PlayDelayThreshold.GetHashCode();
                if (this.PlayAmplitudeThreshold != null) hashCode = hashCode * 59 + this.PlayAmplitudeThreshold.GetHashCode();
                if (this.PlayPrefillData != null) hashCode = hashCode * 59 + this.PlayPrefillData.GetHashCode();
                if (this.RecordRedirectionEnable != null) hashCode = hashCode * 59 + this.RecordRedirectionEnable.GetHashCode();
                hashCode = hashCode * 59 + this.RecordClassification.GetHashCode();
                hashCode = hashCode * 59 + this.RecordQuality.GetHashCode();
                if (this.RecordDenoising != null) hashCode = hashCode * 59 + this.RecordDenoising.GetHashCode();
                if (this.RecordAgc != null) hashCode = hashCode * 59 + this.RecordAgc.GetHashCode();
                hashCode = hashCode * 59 + this.RecordCrc.GetHashCode();
                hashCode = hashCode * 59 + this.RecordDeviceMode.GetHashCode();
                if (this.RecordDelayThreshold != null) hashCode = hashCode * 59 + this.RecordDelayThreshold.GetHashCode();
                if (this.RecordAmplitudeThreshold != null) hashCode = hashCode * 59 + this.RecordAmplitudeThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
