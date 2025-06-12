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
    /// Response Object
    /// </summary>
    public class Show2dModelTrainingJobResponse : SdkResponse
    {
        /// <summary>
        /// 任务的状态。  与MetaStudio Console上用户看到的状态映射关系如下：  - 待提交   * WAIT_FILE_UPLOAD: 待上传文件  - 系统审核中   * AUTO_VERIFYING: 自动审核中   * MANUAL_VERIFYING: 人工审核中  - 系统审核未通过   * AUTO_VERIFY_FAILED: 自动审核失败   * MANUAL_VERIFY_FAILED: 人工审核失败  - 算法训练中   &gt; 算法训练中的状态仅管理员需要处理，普通用户仅需要显示“算法训练中”即可。   * MANUAL_VERIFY_SUCCESS: 审核通过，等待预处理资源   * WAIT_TRAINING_DATA_PREPROCESS: 等待训练数据预处理   * TRAINING_DATA_PREPROCESSING: 训练数据预处理中   * TRAINING_DATA_PREPROCESS_FAILED: 训练数据预处理失败   * TRAINING_DATA_PREPROCESS_SUCCESS: 训练数据预处理完成，等待训练资源中   * TRAINING: 训练中   * TRAIN_FAILED: 训练失败   * TRAIN_SUCCESS: 训练完成，等待预处理资源   * INFERENCE_DATA_PREPROCESSING: 推理数据预处理中   * INFERENCE_DATA_PREPROCESS_FAILED: 推理数据预处理失败   * WAIT_MAIN_FILE_UPLOAD: 等待主文件上传   * MANUAL_STOP_INFERENCE_DATA_PREPROCESS: 人工中止推理预处理   * MANUAL_STOP_TRAIN: 人工中止训练   * MANUAL_STOP_TRAINING_DATA_PREPROCESS: 人工中止训练预处理   * WAIT_ADMIN_CONFIRM: 等待管理员审核   * WAIT_COMPILE: 等待转编译   * COMPILING: 转编译中   * COMPILE_FAILED: 转编译失败   * WAIT_GENERATE_ACTION: 等待原子动作生成   * WAIT_ARRANGE: 等待编排   * ACTION_GENERATE_DATA_PROCESSING: 原子动作生成中   * MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING: 人工中止动作生成   * MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING: 人工中止动作编排   * ACTION_GENERATE_ORI_PROCESSING: 动作编排中   * ACTION_GENERATE_DATA_FAILED: 动作生成失败   * ACTION_GENERATE_ORI_FAILED: 生成动作编排资产失败   * ACTION_GENERATE_ORI_SUCCESS: 动作编排成功   * GENERATE_ACTION_PREPROCESS_FAILED: 生成动作编排原子动作失败   * WAIT_ADMIN_CALIBRATION: 等待管理员确认动作信息   * WAIT_ASSET_SYNC: 等待资产同步  - 待用户审核，仅NA白名单用户有该状态   * WAIT_USER_CONFIRM: 等待用户确认训练效果  - 用户驳回，仅NA白名单用户有该状态   * JOB_REJECT: 驳回任务  - 已完成   * JOB_SUCCESS: 训练任务完成（普通用户任务的完成状态，此时用户已经可以使用模型）   * JOB_FINISH: 任务结束，是最终状态，不支持修改此状态(NA用户任务的完成状态，并且此状态表明模型效果已通过用户的验收)  - 挂起，仅NA白名单用户有该状态   * JOB_PENDING: 挂起任务
        /// </summary>
        /// <value>任务的状态。  与MetaStudio Console上用户看到的状态映射关系如下：  - 待提交   * WAIT_FILE_UPLOAD: 待上传文件  - 系统审核中   * AUTO_VERIFYING: 自动审核中   * MANUAL_VERIFYING: 人工审核中  - 系统审核未通过   * AUTO_VERIFY_FAILED: 自动审核失败   * MANUAL_VERIFY_FAILED: 人工审核失败  - 算法训练中   &gt; 算法训练中的状态仅管理员需要处理，普通用户仅需要显示“算法训练中”即可。   * MANUAL_VERIFY_SUCCESS: 审核通过，等待预处理资源   * WAIT_TRAINING_DATA_PREPROCESS: 等待训练数据预处理   * TRAINING_DATA_PREPROCESSING: 训练数据预处理中   * TRAINING_DATA_PREPROCESS_FAILED: 训练数据预处理失败   * TRAINING_DATA_PREPROCESS_SUCCESS: 训练数据预处理完成，等待训练资源中   * TRAINING: 训练中   * TRAIN_FAILED: 训练失败   * TRAIN_SUCCESS: 训练完成，等待预处理资源   * INFERENCE_DATA_PREPROCESSING: 推理数据预处理中   * INFERENCE_DATA_PREPROCESS_FAILED: 推理数据预处理失败   * WAIT_MAIN_FILE_UPLOAD: 等待主文件上传   * MANUAL_STOP_INFERENCE_DATA_PREPROCESS: 人工中止推理预处理   * MANUAL_STOP_TRAIN: 人工中止训练   * MANUAL_STOP_TRAINING_DATA_PREPROCESS: 人工中止训练预处理   * WAIT_ADMIN_CONFIRM: 等待管理员审核   * WAIT_COMPILE: 等待转编译   * COMPILING: 转编译中   * COMPILE_FAILED: 转编译失败   * WAIT_GENERATE_ACTION: 等待原子动作生成   * WAIT_ARRANGE: 等待编排   * ACTION_GENERATE_DATA_PROCESSING: 原子动作生成中   * MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING: 人工中止动作生成   * MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING: 人工中止动作编排   * ACTION_GENERATE_ORI_PROCESSING: 动作编排中   * ACTION_GENERATE_DATA_FAILED: 动作生成失败   * ACTION_GENERATE_ORI_FAILED: 生成动作编排资产失败   * ACTION_GENERATE_ORI_SUCCESS: 动作编排成功   * GENERATE_ACTION_PREPROCESS_FAILED: 生成动作编排原子动作失败   * WAIT_ADMIN_CALIBRATION: 等待管理员确认动作信息   * WAIT_ASSET_SYNC: 等待资产同步  - 待用户审核，仅NA白名单用户有该状态   * WAIT_USER_CONFIRM: 等待用户确认训练效果  - 用户驳回，仅NA白名单用户有该状态   * JOB_REJECT: 驳回任务  - 已完成   * JOB_SUCCESS: 训练任务完成（普通用户任务的完成状态，此时用户已经可以使用模型）   * JOB_FINISH: 任务结束，是最终状态，不支持修改此状态(NA用户任务的完成状态，并且此状态表明模型效果已通过用户的验收)  - 挂起，仅NA白名单用户有该状态   * JOB_PENDING: 挂起任务</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum WAIT_FILE_UPLOAD for value: WAIT_FILE_UPLOAD
            /// </summary>
            public static readonly StateEnum WAIT_FILE_UPLOAD = new StateEnum("WAIT_FILE_UPLOAD");

            /// <summary>
            /// Enum AUTO_VERIFYING for value: AUTO_VERIFYING
            /// </summary>
            public static readonly StateEnum AUTO_VERIFYING = new StateEnum("AUTO_VERIFYING");

            /// <summary>
            /// Enum AUTO_VERIFY_FAILED for value: AUTO_VERIFY_FAILED
            /// </summary>
            public static readonly StateEnum AUTO_VERIFY_FAILED = new StateEnum("AUTO_VERIFY_FAILED");

            /// <summary>
            /// Enum MANUAL_VERIFYING for value: MANUAL_VERIFYING
            /// </summary>
            public static readonly StateEnum MANUAL_VERIFYING = new StateEnum("MANUAL_VERIFYING");

            /// <summary>
            /// Enum WAIT_TRAINING_DATA_PREPROCESS for value: WAIT_TRAINING_DATA_PREPROCESS
            /// </summary>
            public static readonly StateEnum WAIT_TRAINING_DATA_PREPROCESS = new StateEnum("WAIT_TRAINING_DATA_PREPROCESS");

            /// <summary>
            /// Enum MANUAL_VERIFY_FAILED for value: MANUAL_VERIFY_FAILED
            /// </summary>
            public static readonly StateEnum MANUAL_VERIFY_FAILED = new StateEnum("MANUAL_VERIFY_FAILED");

            /// <summary>
            /// Enum MANUAL_VERIFY_SUCCESS for value: MANUAL_VERIFY_SUCCESS
            /// </summary>
            public static readonly StateEnum MANUAL_VERIFY_SUCCESS = new StateEnum("MANUAL_VERIFY_SUCCESS");

            /// <summary>
            /// Enum TRAINING_DATA_PREPROCESSING for value: TRAINING_DATA_PREPROCESSING
            /// </summary>
            public static readonly StateEnum TRAINING_DATA_PREPROCESSING = new StateEnum("TRAINING_DATA_PREPROCESSING");

            /// <summary>
            /// Enum TRAINING_DATA_PREPROCESS_FAILED for value: TRAINING_DATA_PREPROCESS_FAILED
            /// </summary>
            public static readonly StateEnum TRAINING_DATA_PREPROCESS_FAILED = new StateEnum("TRAINING_DATA_PREPROCESS_FAILED");

            /// <summary>
            /// Enum TRAINING_DATA_PREPROCESS_SUCCESS for value: TRAINING_DATA_PREPROCESS_SUCCESS
            /// </summary>
            public static readonly StateEnum TRAINING_DATA_PREPROCESS_SUCCESS = new StateEnum("TRAINING_DATA_PREPROCESS_SUCCESS");

            /// <summary>
            /// Enum TRAINING for value: TRAINING
            /// </summary>
            public static readonly StateEnum TRAINING = new StateEnum("TRAINING");

            /// <summary>
            /// Enum TRAIN_FAILED for value: TRAIN_FAILED
            /// </summary>
            public static readonly StateEnum TRAIN_FAILED = new StateEnum("TRAIN_FAILED");

            /// <summary>
            /// Enum TRAIN_SUCCESS for value: TRAIN_SUCCESS
            /// </summary>
            public static readonly StateEnum TRAIN_SUCCESS = new StateEnum("TRAIN_SUCCESS");

            /// <summary>
            /// Enum INFERENCE_DATA_PREPROCESSING for value: INFERENCE_DATA_PREPROCESSING
            /// </summary>
            public static readonly StateEnum INFERENCE_DATA_PREPROCESSING = new StateEnum("INFERENCE_DATA_PREPROCESSING");

            /// <summary>
            /// Enum INFERENCE_DATA_PREPROCESS_FAILED for value: INFERENCE_DATA_PREPROCESS_FAILED
            /// </summary>
            public static readonly StateEnum INFERENCE_DATA_PREPROCESS_FAILED = new StateEnum("INFERENCE_DATA_PREPROCESS_FAILED");

            /// <summary>
            /// Enum WAIT_MASK_UPLOAD for value: WAIT_MASK_UPLOAD
            /// </summary>
            public static readonly StateEnum WAIT_MASK_UPLOAD = new StateEnum("WAIT_MASK_UPLOAD");

            /// <summary>
            /// Enum WAIT_MAIN_FILE_UPLOAD for value: WAIT_MAIN_FILE_UPLOAD
            /// </summary>
            public static readonly StateEnum WAIT_MAIN_FILE_UPLOAD = new StateEnum("WAIT_MAIN_FILE_UPLOAD");

            /// <summary>
            /// Enum JOB_SUCCESS for value: JOB_SUCCESS
            /// </summary>
            public static readonly StateEnum JOB_SUCCESS = new StateEnum("JOB_SUCCESS");

            /// <summary>
            /// Enum MANUAL_STOP_INFERENCE_DATA_PREPROCESS for value: MANUAL_STOP_INFERENCE_DATA_PREPROCESS
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_INFERENCE_DATA_PREPROCESS = new StateEnum("MANUAL_STOP_INFERENCE_DATA_PREPROCESS");

            /// <summary>
            /// Enum MANUAL_STOP_TRAIN for value: MANUAL_STOP_TRAIN
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_TRAIN = new StateEnum("MANUAL_STOP_TRAIN");

            /// <summary>
            /// Enum MANUAL_STOP_TRAINING_DATA_PREPROCESS for value: MANUAL_STOP_TRAINING_DATA_PREPROCESS
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_TRAINING_DATA_PREPROCESS = new StateEnum("MANUAL_STOP_TRAINING_DATA_PREPROCESS");

            /// <summary>
            /// Enum MANUAL_STOP_BEAUTY_PREPROCESS for value: MANUAL_STOP_BEAUTY_PREPROCESS
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_BEAUTY_PREPROCESS = new StateEnum("MANUAL_STOP_BEAUTY_PREPROCESS");

            /// <summary>
            /// Enum WAIT_USER_CONFIRM for value: WAIT_USER_CONFIRM
            /// </summary>
            public static readonly StateEnum WAIT_USER_CONFIRM = new StateEnum("WAIT_USER_CONFIRM");

            /// <summary>
            /// Enum JOB_REJECT for value: JOB_REJECT
            /// </summary>
            public static readonly StateEnum JOB_REJECT = new StateEnum("JOB_REJECT");

            /// <summary>
            /// Enum JOB_PENDING for value: JOB_PENDING
            /// </summary>
            public static readonly StateEnum JOB_PENDING = new StateEnum("JOB_PENDING");

            /// <summary>
            /// Enum WAIT_ASSET_SYNC for value: WAIT_ASSET_SYNC
            /// </summary>
            public static readonly StateEnum WAIT_ASSET_SYNC = new StateEnum("WAIT_ASSET_SYNC");

            /// <summary>
            /// Enum WAIT_ADMIN_CONFIRM for value: WAIT_ADMIN_CONFIRM
            /// </summary>
            public static readonly StateEnum WAIT_ADMIN_CONFIRM = new StateEnum("WAIT_ADMIN_CONFIRM");

            /// <summary>
            /// Enum JOB_FINISH for value: JOB_FINISH
            /// </summary>
            public static readonly StateEnum JOB_FINISH = new StateEnum("JOB_FINISH");

            /// <summary>
            /// Enum COMPILING for value: COMPILING
            /// </summary>
            public static readonly StateEnum COMPILING = new StateEnum("COMPILING");

            /// <summary>
            /// Enum WAIT_COMPILE for value: WAIT_COMPILE
            /// </summary>
            public static readonly StateEnum WAIT_COMPILE = new StateEnum("WAIT_COMPILE");

            /// <summary>
            /// Enum COMPILE_FAILED for value: COMPILE_FAILED
            /// </summary>
            public static readonly StateEnum COMPILE_FAILED = new StateEnum("COMPILE_FAILED");

            /// <summary>
            /// Enum WAIT_BEAUTY for value: WAIT_BEAUTY
            /// </summary>
            public static readonly StateEnum WAIT_BEAUTY = new StateEnum("WAIT_BEAUTY");

            /// <summary>
            /// Enum WAIT_GENERATE_ACTION for value: WAIT_GENERATE_ACTION
            /// </summary>
            public static readonly StateEnum WAIT_GENERATE_ACTION = new StateEnum("WAIT_GENERATE_ACTION");

            /// <summary>
            /// Enum WAIT_ARRANGE for value: WAIT_ARRANGE
            /// </summary>
            public static readonly StateEnum WAIT_ARRANGE = new StateEnum("WAIT_ARRANGE");

            /// <summary>
            /// Enum ACTION_GENERATE_DATA_PROCESSING for value: ACTION_GENERATE_DATA_PROCESSING
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_DATA_PROCESSING = new StateEnum("ACTION_GENERATE_DATA_PROCESSING");

            /// <summary>
            /// Enum MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING for value: MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING = new StateEnum("MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING");

            /// <summary>
            /// Enum MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING for value: MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING = new StateEnum("MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING");

            /// <summary>
            /// Enum ACTION_GENERATE_ORI_PROCESSING for value: ACTION_GENERATE_ORI_PROCESSING
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_ORI_PROCESSING = new StateEnum("ACTION_GENERATE_ORI_PROCESSING");

            /// <summary>
            /// Enum ACTION_GENERATE_DATA_FAILED for value: ACTION_GENERATE_DATA_FAILED
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_DATA_FAILED = new StateEnum("ACTION_GENERATE_DATA_FAILED");

            /// <summary>
            /// Enum ACTION_GENERATE_ORI_FAILED for value: ACTION_GENERATE_ORI_FAILED
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_ORI_FAILED = new StateEnum("ACTION_GENERATE_ORI_FAILED");

            /// <summary>
            /// Enum ACTION_GENERATE_ORI_SUCCESS for value: ACTION_GENERATE_ORI_SUCCESS
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_ORI_SUCCESS = new StateEnum("ACTION_GENERATE_ORI_SUCCESS");

            /// <summary>
            /// Enum GENERATE_ACTION_PREPROCESS_FAILED for value: GENERATE_ACTION_PREPROCESS_FAILED
            /// </summary>
            public static readonly StateEnum GENERATE_ACTION_PREPROCESS_FAILED = new StateEnum("GENERATE_ACTION_PREPROCESS_FAILED");

            /// <summary>
            /// Enum WAIT_ADMIN_CALIBRATION for value: WAIT_ADMIN_CALIBRATION
            /// </summary>
            public static readonly StateEnum WAIT_ADMIN_CALIBRATION = new StateEnum("WAIT_ADMIN_CALIBRATION");

            /// <summary>
            /// Enum BEAUTY_VIDEO_FILE_UPLOADED for value: BEAUTY_VIDEO_FILE_UPLOADED
            /// </summary>
            public static readonly StateEnum BEAUTY_VIDEO_FILE_UPLOADED = new StateEnum("BEAUTY_VIDEO_FILE_UPLOADED");

            /// <summary>
            /// Enum BEAUTYFACE_SUCCESS for value: BEAUTYFACE_SUCCESS
            /// </summary>
            public static readonly StateEnum BEAUTYFACE_SUCCESS = new StateEnum("BEAUTYFACE_SUCCESS");

            /// <summary>
            /// Enum BEAUTYFACE_FAILED for value: BEAUTYFACE_FAILED
            /// </summary>
            public static readonly StateEnum BEAUTYFACE_FAILED = new StateEnum("BEAUTYFACE_FAILED");

            /// <summary>
            /// Enum WAIT_BEAUTY_VIDEO_FILE_UPLOAD for value: WAIT_BEAUTY_VIDEO_FILE_UPLOAD
            /// </summary>
            public static readonly StateEnum WAIT_BEAUTY_VIDEO_FILE_UPLOAD = new StateEnum("WAIT_BEAUTY_VIDEO_FILE_UPLOAD");

            /// <summary>
            /// Enum BEAUTYFACE_ROCESSING for value: BEAUTYFACE_ROCESSING
            /// </summary>
            public static readonly StateEnum BEAUTYFACE_ROCESSING = new StateEnum("BEAUTYFACE_ROCESSING");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "WAIT_FILE_UPLOAD", WAIT_FILE_UPLOAD },
                { "AUTO_VERIFYING", AUTO_VERIFYING },
                { "AUTO_VERIFY_FAILED", AUTO_VERIFY_FAILED },
                { "MANUAL_VERIFYING", MANUAL_VERIFYING },
                { "WAIT_TRAINING_DATA_PREPROCESS", WAIT_TRAINING_DATA_PREPROCESS },
                { "MANUAL_VERIFY_FAILED", MANUAL_VERIFY_FAILED },
                { "MANUAL_VERIFY_SUCCESS", MANUAL_VERIFY_SUCCESS },
                { "TRAINING_DATA_PREPROCESSING", TRAINING_DATA_PREPROCESSING },
                { "TRAINING_DATA_PREPROCESS_FAILED", TRAINING_DATA_PREPROCESS_FAILED },
                { "TRAINING_DATA_PREPROCESS_SUCCESS", TRAINING_DATA_PREPROCESS_SUCCESS },
                { "TRAINING", TRAINING },
                { "TRAIN_FAILED", TRAIN_FAILED },
                { "TRAIN_SUCCESS", TRAIN_SUCCESS },
                { "INFERENCE_DATA_PREPROCESSING", INFERENCE_DATA_PREPROCESSING },
                { "INFERENCE_DATA_PREPROCESS_FAILED", INFERENCE_DATA_PREPROCESS_FAILED },
                { "WAIT_MASK_UPLOAD", WAIT_MASK_UPLOAD },
                { "WAIT_MAIN_FILE_UPLOAD", WAIT_MAIN_FILE_UPLOAD },
                { "JOB_SUCCESS", JOB_SUCCESS },
                { "MANUAL_STOP_INFERENCE_DATA_PREPROCESS", MANUAL_STOP_INFERENCE_DATA_PREPROCESS },
                { "MANUAL_STOP_TRAIN", MANUAL_STOP_TRAIN },
                { "MANUAL_STOP_TRAINING_DATA_PREPROCESS", MANUAL_STOP_TRAINING_DATA_PREPROCESS },
                { "MANUAL_STOP_BEAUTY_PREPROCESS", MANUAL_STOP_BEAUTY_PREPROCESS },
                { "WAIT_USER_CONFIRM", WAIT_USER_CONFIRM },
                { "JOB_REJECT", JOB_REJECT },
                { "JOB_PENDING", JOB_PENDING },
                { "WAIT_ASSET_SYNC", WAIT_ASSET_SYNC },
                { "WAIT_ADMIN_CONFIRM", WAIT_ADMIN_CONFIRM },
                { "JOB_FINISH", JOB_FINISH },
                { "COMPILING", COMPILING },
                { "WAIT_COMPILE", WAIT_COMPILE },
                { "COMPILE_FAILED", COMPILE_FAILED },
                { "WAIT_BEAUTY", WAIT_BEAUTY },
                { "WAIT_GENERATE_ACTION", WAIT_GENERATE_ACTION },
                { "WAIT_ARRANGE", WAIT_ARRANGE },
                { "ACTION_GENERATE_DATA_PROCESSING", ACTION_GENERATE_DATA_PROCESSING },
                { "MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING", MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING },
                { "MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING", MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING },
                { "ACTION_GENERATE_ORI_PROCESSING", ACTION_GENERATE_ORI_PROCESSING },
                { "ACTION_GENERATE_DATA_FAILED", ACTION_GENERATE_DATA_FAILED },
                { "ACTION_GENERATE_ORI_FAILED", ACTION_GENERATE_ORI_FAILED },
                { "ACTION_GENERATE_ORI_SUCCESS", ACTION_GENERATE_ORI_SUCCESS },
                { "GENERATE_ACTION_PREPROCESS_FAILED", GENERATE_ACTION_PREPROCESS_FAILED },
                { "WAIT_ADMIN_CALIBRATION", WAIT_ADMIN_CALIBRATION },
                { "BEAUTY_VIDEO_FILE_UPLOADED", BEAUTY_VIDEO_FILE_UPLOADED },
                { "BEAUTYFACE_SUCCESS", BEAUTYFACE_SUCCESS },
                { "BEAUTYFACE_FAILED", BEAUTYFACE_FAILED },
                { "WAIT_BEAUTY_VIDEO_FILE_UPLOAD", WAIT_BEAUTY_VIDEO_FILE_UPLOAD },
                { "BEAUTYFACE_ROCESSING", BEAUTYFACE_ROCESSING },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 分身数字人模型版本。默认是V3.2版本模型。 * V3.2：V3.2版本模型 &gt; * V3和V2版本已废弃不用
        /// </summary>
        /// <value>分身数字人模型版本。默认是V3.2版本模型。 * V3.2：V3.2版本模型 &gt; * V3和V2版本已废弃不用</value>
        [JsonConverter(typeof(EnumClassConverter<ModelVersionEnum>))]
        public class ModelVersionEnum
        {
            /// <summary>
            /// Enum V2 for value: V2
            /// </summary>
            public static readonly ModelVersionEnum V2 = new ModelVersionEnum("V2");

            /// <summary>
            /// Enum V3 for value: V3
            /// </summary>
            public static readonly ModelVersionEnum V3 = new ModelVersionEnum("V3");

            /// <summary>
            /// Enum V3_2 for value: V3.2
            /// </summary>
            public static readonly ModelVersionEnum V3_2 = new ModelVersionEnum("V3.2");

            private static readonly Dictionary<string, ModelVersionEnum> StaticFields =
            new Dictionary<string, ModelVersionEnum>()
            {
                { "V2", V2 },
                { "V3", V3 },
                { "V3.2", V3_2 },
            };

            private string _value;

            public ModelVersionEnum()
            {

            }

            public ModelVersionEnum(string value)
            {
                _value = value;
            }

            public static ModelVersionEnum FromValue(string value)
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

                if (this.Equals(obj as ModelVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModelVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModelVersionEnum a, ModelVersionEnum b)
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

            public static bool operator !=(ModelVersionEnum a, ModelVersionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 抠图类型。默认是AI。 * AI：AI抠图 * MANUAL：人工抠图
        /// </summary>
        /// <value>抠图类型。默认是AI。 * AI：AI抠图 * MANUAL：人工抠图</value>
        [JsonConverter(typeof(EnumClassConverter<MattingTypeEnum>))]
        public class MattingTypeEnum
        {
            /// <summary>
            /// Enum AI for value: AI
            /// </summary>
            public static readonly MattingTypeEnum AI = new MattingTypeEnum("AI");

            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            public static readonly MattingTypeEnum MANUAL = new MattingTypeEnum("MANUAL");

            private static readonly Dictionary<string, MattingTypeEnum> StaticFields =
            new Dictionary<string, MattingTypeEnum>()
            {
                { "AI", AI },
                { "MANUAL", MANUAL },
            };

            private string _value;

            public MattingTypeEnum()
            {

            }

            public MattingTypeEnum(string value)
            {
                _value = value;
            }

            public static MattingTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MattingTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MattingTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MattingTypeEnum a, MattingTypeEnum b)
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

            public static bool operator !=(MattingTypeEnum a, MattingTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 声音来源类型 * VIDEO：视频中抽取音频 * AUDIO：单独上传的音频
        /// </summary>
        /// <value>声音来源类型 * VIDEO：视频中抽取音频 * AUDIO：单独上传的音频</value>
        [JsonConverter(typeof(EnumClassConverter<AudioSourceTypeEnum>))]
        public class AudioSourceTypeEnum
        {
            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            public static readonly AudioSourceTypeEnum VIDEO = new AudioSourceTypeEnum("VIDEO");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly AudioSourceTypeEnum AUDIO = new AudioSourceTypeEnum("AUDIO");

            private static readonly Dictionary<string, AudioSourceTypeEnum> StaticFields =
            new Dictionary<string, AudioSourceTypeEnum>()
            {
                { "VIDEO", VIDEO },
                { "AUDIO", AUDIO },
            };

            private string _value;

            public AudioSourceTypeEnum()
            {

            }

            public AudioSourceTypeEnum(string value)
            {
                _value = value;
            }

            public static AudioSourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AudioSourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioSourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AudioSourceTypeEnum a, AudioSourceTypeEnum b)
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

            public static bool operator !=(AudioSourceTypeEnum a, AudioSourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 分身数字人模型名称。该名称会作为资产库中分身数字人模型资产名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务的状态。  与MetaStudio Console上用户看到的状态映射关系如下：  - 待提交   * WAIT_FILE_UPLOAD: 待上传文件  - 系统审核中   * AUTO_VERIFYING: 自动审核中   * MANUAL_VERIFYING: 人工审核中  - 系统审核未通过   * AUTO_VERIFY_FAILED: 自动审核失败   * MANUAL_VERIFY_FAILED: 人工审核失败  - 算法训练中   &gt; 算法训练中的状态仅管理员需要处理，普通用户仅需要显示“算法训练中”即可。   * MANUAL_VERIFY_SUCCESS: 审核通过，等待预处理资源   * WAIT_TRAINING_DATA_PREPROCESS: 等待训练数据预处理   * TRAINING_DATA_PREPROCESSING: 训练数据预处理中   * TRAINING_DATA_PREPROCESS_FAILED: 训练数据预处理失败   * TRAINING_DATA_PREPROCESS_SUCCESS: 训练数据预处理完成，等待训练资源中   * TRAINING: 训练中   * TRAIN_FAILED: 训练失败   * TRAIN_SUCCESS: 训练完成，等待预处理资源   * INFERENCE_DATA_PREPROCESSING: 推理数据预处理中   * INFERENCE_DATA_PREPROCESS_FAILED: 推理数据预处理失败   * WAIT_MAIN_FILE_UPLOAD: 等待主文件上传   * MANUAL_STOP_INFERENCE_DATA_PREPROCESS: 人工中止推理预处理   * MANUAL_STOP_TRAIN: 人工中止训练   * MANUAL_STOP_TRAINING_DATA_PREPROCESS: 人工中止训练预处理   * WAIT_ADMIN_CONFIRM: 等待管理员审核   * WAIT_COMPILE: 等待转编译   * COMPILING: 转编译中   * COMPILE_FAILED: 转编译失败   * WAIT_GENERATE_ACTION: 等待原子动作生成   * WAIT_ARRANGE: 等待编排   * ACTION_GENERATE_DATA_PROCESSING: 原子动作生成中   * MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING: 人工中止动作生成   * MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING: 人工中止动作编排   * ACTION_GENERATE_ORI_PROCESSING: 动作编排中   * ACTION_GENERATE_DATA_FAILED: 动作生成失败   * ACTION_GENERATE_ORI_FAILED: 生成动作编排资产失败   * ACTION_GENERATE_ORI_SUCCESS: 动作编排成功   * GENERATE_ACTION_PREPROCESS_FAILED: 生成动作编排原子动作失败   * WAIT_ADMIN_CALIBRATION: 等待管理员确认动作信息   * WAIT_ASSET_SYNC: 等待资产同步  - 待用户审核，仅NA白名单用户有该状态   * WAIT_USER_CONFIRM: 等待用户确认训练效果  - 用户驳回，仅NA白名单用户有该状态   * JOB_REJECT: 驳回任务  - 已完成   * JOB_SUCCESS: 训练任务完成（普通用户任务的完成状态，此时用户已经可以使用模型）   * JOB_FINISH: 任务结束，是最终状态，不支持修改此状态(NA用户任务的完成状态，并且此状态表明模型效果已通过用户的验收)  - 挂起，仅NA白名单用户有该状态   * JOB_PENDING: 挂起任务
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 模型资产ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 模型资产所属项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 分身数字人模型封面下载URL。URL有效期24小时。
        /// </summary>
        [JsonProperty("cover_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverDownloadUrl { get; set; }

        /// <summary>
        /// 用户最近一次更新任务的时间（包括租户创建或者重新提交），格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 分身数字人训练任务创建者的手机号。
        /// </summary>
        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public string Contact { get; set; }

        /// <summary>
        /// 分身数字人训练任务的批次名称。
        /// </summary>
        [JsonProperty("batch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchName { get; set; }

        /// <summary>
        /// 分身数字人训练任务标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 分身数字人模型版本。默认是V3.2版本模型。 * V3.2：V3.2版本模型 &gt; * V3和V2版本已废弃不用
        /// </summary>
        [JsonProperty("model_version", NullValueHandling = NullValueHandling.Ignore)]
        public ModelVersionEnum ModelVersion { get; set; }
        /// <summary>
        /// 抠图类型。默认是AI。 * AI：AI抠图 * MANUAL：人工抠图
        /// </summary>
        [JsonProperty("matting_type", NullValueHandling = NullValueHandling.Ignore)]
        public MattingTypeEnum MattingType { get; set; }
        /// <summary>
        /// 分身数字人模型分辨率。默认是1080P。 * 1080P：1080P。支持1080P及720P的视频输出。 * 4K：4K。支持4K、1080P及720P的视频输出。
        /// </summary>
        [JsonProperty("model_resolution", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelResolution { get; set; }

        /// <summary>
        /// 自定义用户id（如创建任务时设置了X-App-UserId则会携带）。
        /// </summary>
        [JsonProperty("app_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppUserId { get; set; }

        /// <summary>
        /// 是否是基础版的形象训练
        /// </summary>
        [JsonProperty("is_flexus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFlexus { get; set; }

        /// <summary>
        /// 是否只训练形象模型，不训练声音模型。仅Flexus版本时有效，默认false。
        /// </summary>
        [JsonProperty("is_only_human_model", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOnlyHumanModel { get; set; }

        /// <summary>
        /// 分身数字人训练视频下载URL。24小时内有效。
        /// </summary>
        [JsonProperty("training_video_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingVideoDownloadUrl { get; set; }

        /// <summary>
        /// 身份证正面照片下载URL。24小时内有效。
        /// </summary>
        [JsonProperty("id_card_image1_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IdCardImage1DownloadUrl { get; set; }

        /// <summary>
        /// 身份证反面照片下载URL。24小时内有效。
        /// </summary>
        [JsonProperty("id_card_image2_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IdCardImage2DownloadUrl { get; set; }

        /// <summary>
        /// 授权书下载URL。24小时内有效。
        /// </summary>
        [JsonProperty("grant_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantFileDownloadUrl { get; set; }

        /// <summary>
        /// 美白前图片下载url。
        /// </summary>
        [JsonProperty("pre_beauty_image_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PreBeautyImageDownloadUrl { get; set; }

        /// <summary>
        /// 动作视频
        /// </summary>
        [JsonProperty("action_video_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionVideoDownloadUrl { get; set; }

        /// <summary>
        /// 美白后图片下载url。
        /// </summary>
        [JsonProperty("post_beauty_image_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PostBeautyImageDownloadUrl { get; set; }

        /// <summary>
        /// 音频文件下载url。
        /// </summary>
        [JsonProperty("audio_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioFileDownloadUrl { get; set; }

        /// <summary>
        /// 操作日志列表。
        /// </summary>
        [JsonProperty("operation_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<OperationLogInfo> OperationLogs { get; set; }

        /// <summary>
        /// 生成抠图验证视频时不抠图区域。
        /// </summary>
        [JsonProperty("verify_video_matting_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<VerifyVideoMattingInfo> VerifyVideoMattingInfo { get; set; }

        /// <summary>
        /// 评论记录列表。
        /// </summary>
        [JsonProperty("comment_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommentLogInfo> CommentLogs { get; set; }

        /// <summary>
        /// 动作视频样例。
        /// </summary>
        [JsonProperty("samples", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionSampleInfo> Samples { get; set; }

        /// <summary>
        /// 遮罩文件是否已上传。
        /// </summary>
        [JsonProperty("is_mask_file_uploaded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMaskFileUploaded { get; set; }

        /// <summary>
        /// 遮罩下载URL。24小时内有效。
        /// </summary>
        [JsonProperty("mask_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskFileDownloadUrl { get; set; }

        /// <summary>
        /// 制作审核视频
        /// </summary>
        [JsonProperty("verify_video_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyVideoDownloadUrl { get; set; }

        /// <summary>
        /// 标注视频url下载链接。24小时内有效。
        /// </summary>
        [JsonProperty("markable_video_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string MarkableVideoDownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("traning_video_mark_info", NullValueHandling = NullValueHandling.Ignore)]
        public TrainingVideoMarkInfo TraningVideoMarkInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inference_data_process_video_mark_info", NullValueHandling = NullValueHandling.Ignore)]
        public InferenceVideoMarkInfo InferenceDataProcessVideoMarkInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inference_data_process_action_mark_info", NullValueHandling = NullValueHandling.Ignore)]
        public InferenceActionMarkInfo InferenceDataProcessActionMarkInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inference_data_process_chat_action_mark_info", NullValueHandling = NullValueHandling.Ignore)]
        public InferenceActionMarkInfo InferenceDataProcessChatActionMarkInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inference_data_process_eye_correction_mark_info", NullValueHandling = NullValueHandling.Ignore)]
        public InferenceEyeCorrectionMarkInfo InferenceDataProcessEyeCorrectionMarkInfo { get; set; }

        /// <summary>
        /// 分身数字人是否需要背景替换。需要背景替换的分身数字人训练视频需要绿幕拍摄。
        /// </summary>
        [JsonProperty("is_background_replacement", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBackgroundReplacement { get; set; }

        /// <summary>
        /// 转编译任务机型
        /// </summary>
        [JsonProperty("worker_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WorkerType { get; set; }

        /// <summary>
        /// 声音训练任务id。
        /// </summary>
        [JsonProperty("voice_train_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceTrainJobId { get; set; }

        /// <summary>
        /// flexus版本任务剩余可以重训的次数，每重训一次减1，减到0时不可再重训。
        /// </summary>
        [JsonProperty("flexus_retry_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlexusRetryCount { get; set; }

        /// <summary>
        /// 声音来源类型 * VIDEO：视频中抽取音频 * AUDIO：单独上传的音频
        /// </summary>
        [JsonProperty("audio_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public AudioSourceTypeEnum AudioSourceType { get; set; }
        /// <summary>
        /// 该任务所生成的模型支持的业务类型，可多选。  Flexus版数字人仅支持选择“VIDEO_2D”。
        /// </summary>
        [JsonProperty("supported_service", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportedServiceEnum> SupportedService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allocated_resource", NullValueHandling = NullValueHandling.Ignore)]
        public TrainingAllocatedResource AllocatedResource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Show2dModelTrainingJobResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  coverDownloadUrl: ").Append(CoverDownloadUrl).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  contact: ").Append(Contact).Append("\n");
            sb.Append("  batchName: ").Append(BatchName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  modelVersion: ").Append(ModelVersion).Append("\n");
            sb.Append("  mattingType: ").Append(MattingType).Append("\n");
            sb.Append("  modelResolution: ").Append(ModelResolution).Append("\n");
            sb.Append("  appUserId: ").Append(AppUserId).Append("\n");
            sb.Append("  isFlexus: ").Append(IsFlexus).Append("\n");
            sb.Append("  isOnlyHumanModel: ").Append(IsOnlyHumanModel).Append("\n");
            sb.Append("  trainingVideoDownloadUrl: ").Append(TrainingVideoDownloadUrl).Append("\n");
            sb.Append("  idCardImage1DownloadUrl: ").Append(IdCardImage1DownloadUrl).Append("\n");
            sb.Append("  idCardImage2DownloadUrl: ").Append(IdCardImage2DownloadUrl).Append("\n");
            sb.Append("  grantFileDownloadUrl: ").Append(GrantFileDownloadUrl).Append("\n");
            sb.Append("  preBeautyImageDownloadUrl: ").Append(PreBeautyImageDownloadUrl).Append("\n");
            sb.Append("  actionVideoDownloadUrl: ").Append(ActionVideoDownloadUrl).Append("\n");
            sb.Append("  postBeautyImageDownloadUrl: ").Append(PostBeautyImageDownloadUrl).Append("\n");
            sb.Append("  audioFileDownloadUrl: ").Append(AudioFileDownloadUrl).Append("\n");
            sb.Append("  operationLogs: ").Append(OperationLogs).Append("\n");
            sb.Append("  verifyVideoMattingInfo: ").Append(VerifyVideoMattingInfo).Append("\n");
            sb.Append("  commentLogs: ").Append(CommentLogs).Append("\n");
            sb.Append("  samples: ").Append(Samples).Append("\n");
            sb.Append("  isMaskFileUploaded: ").Append(IsMaskFileUploaded).Append("\n");
            sb.Append("  maskFileDownloadUrl: ").Append(MaskFileDownloadUrl).Append("\n");
            sb.Append("  verifyVideoDownloadUrl: ").Append(VerifyVideoDownloadUrl).Append("\n");
            sb.Append("  markableVideoDownloadUrl: ").Append(MarkableVideoDownloadUrl).Append("\n");
            sb.Append("  traningVideoMarkInfo: ").Append(TraningVideoMarkInfo).Append("\n");
            sb.Append("  inferenceDataProcessVideoMarkInfo: ").Append(InferenceDataProcessVideoMarkInfo).Append("\n");
            sb.Append("  inferenceDataProcessActionMarkInfo: ").Append(InferenceDataProcessActionMarkInfo).Append("\n");
            sb.Append("  inferenceDataProcessChatActionMarkInfo: ").Append(InferenceDataProcessChatActionMarkInfo).Append("\n");
            sb.Append("  inferenceDataProcessEyeCorrectionMarkInfo: ").Append(InferenceDataProcessEyeCorrectionMarkInfo).Append("\n");
            sb.Append("  isBackgroundReplacement: ").Append(IsBackgroundReplacement).Append("\n");
            sb.Append("  workerType: ").Append(WorkerType).Append("\n");
            sb.Append("  voiceTrainJobId: ").Append(VoiceTrainJobId).Append("\n");
            sb.Append("  flexusRetryCount: ").Append(FlexusRetryCount).Append("\n");
            sb.Append("  audioSourceType: ").Append(AudioSourceType).Append("\n");
            sb.Append("  supportedService: ").Append(SupportedService).Append("\n");
            sb.Append("  allocatedResource: ").Append(AllocatedResource).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Show2dModelTrainingJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Show2dModelTrainingJobResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.State != input.State) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CoverDownloadUrl != input.CoverDownloadUrl || (this.CoverDownloadUrl != null && !this.CoverDownloadUrl.Equals(input.CoverDownloadUrl))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Contact != input.Contact || (this.Contact != null && !this.Contact.Equals(input.Contact))) return false;
            if (this.BatchName != input.BatchName || (this.BatchName != null && !this.BatchName.Equals(input.BatchName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ModelVersion != input.ModelVersion) return false;
            if (this.MattingType != input.MattingType) return false;
            if (this.ModelResolution != input.ModelResolution || (this.ModelResolution != null && !this.ModelResolution.Equals(input.ModelResolution))) return false;
            if (this.AppUserId != input.AppUserId || (this.AppUserId != null && !this.AppUserId.Equals(input.AppUserId))) return false;
            if (this.IsFlexus != input.IsFlexus || (this.IsFlexus != null && !this.IsFlexus.Equals(input.IsFlexus))) return false;
            if (this.IsOnlyHumanModel != input.IsOnlyHumanModel || (this.IsOnlyHumanModel != null && !this.IsOnlyHumanModel.Equals(input.IsOnlyHumanModel))) return false;
            if (this.TrainingVideoDownloadUrl != input.TrainingVideoDownloadUrl || (this.TrainingVideoDownloadUrl != null && !this.TrainingVideoDownloadUrl.Equals(input.TrainingVideoDownloadUrl))) return false;
            if (this.IdCardImage1DownloadUrl != input.IdCardImage1DownloadUrl || (this.IdCardImage1DownloadUrl != null && !this.IdCardImage1DownloadUrl.Equals(input.IdCardImage1DownloadUrl))) return false;
            if (this.IdCardImage2DownloadUrl != input.IdCardImage2DownloadUrl || (this.IdCardImage2DownloadUrl != null && !this.IdCardImage2DownloadUrl.Equals(input.IdCardImage2DownloadUrl))) return false;
            if (this.GrantFileDownloadUrl != input.GrantFileDownloadUrl || (this.GrantFileDownloadUrl != null && !this.GrantFileDownloadUrl.Equals(input.GrantFileDownloadUrl))) return false;
            if (this.PreBeautyImageDownloadUrl != input.PreBeautyImageDownloadUrl || (this.PreBeautyImageDownloadUrl != null && !this.PreBeautyImageDownloadUrl.Equals(input.PreBeautyImageDownloadUrl))) return false;
            if (this.ActionVideoDownloadUrl != input.ActionVideoDownloadUrl || (this.ActionVideoDownloadUrl != null && !this.ActionVideoDownloadUrl.Equals(input.ActionVideoDownloadUrl))) return false;
            if (this.PostBeautyImageDownloadUrl != input.PostBeautyImageDownloadUrl || (this.PostBeautyImageDownloadUrl != null && !this.PostBeautyImageDownloadUrl.Equals(input.PostBeautyImageDownloadUrl))) return false;
            if (this.AudioFileDownloadUrl != input.AudioFileDownloadUrl || (this.AudioFileDownloadUrl != null && !this.AudioFileDownloadUrl.Equals(input.AudioFileDownloadUrl))) return false;
            if (this.OperationLogs != input.OperationLogs || (this.OperationLogs != null && input.OperationLogs != null && !this.OperationLogs.SequenceEqual(input.OperationLogs))) return false;
            if (this.VerifyVideoMattingInfo != input.VerifyVideoMattingInfo || (this.VerifyVideoMattingInfo != null && input.VerifyVideoMattingInfo != null && !this.VerifyVideoMattingInfo.SequenceEqual(input.VerifyVideoMattingInfo))) return false;
            if (this.CommentLogs != input.CommentLogs || (this.CommentLogs != null && input.CommentLogs != null && !this.CommentLogs.SequenceEqual(input.CommentLogs))) return false;
            if (this.Samples != input.Samples || (this.Samples != null && input.Samples != null && !this.Samples.SequenceEqual(input.Samples))) return false;
            if (this.IsMaskFileUploaded != input.IsMaskFileUploaded || (this.IsMaskFileUploaded != null && !this.IsMaskFileUploaded.Equals(input.IsMaskFileUploaded))) return false;
            if (this.MaskFileDownloadUrl != input.MaskFileDownloadUrl || (this.MaskFileDownloadUrl != null && !this.MaskFileDownloadUrl.Equals(input.MaskFileDownloadUrl))) return false;
            if (this.VerifyVideoDownloadUrl != input.VerifyVideoDownloadUrl || (this.VerifyVideoDownloadUrl != null && !this.VerifyVideoDownloadUrl.Equals(input.VerifyVideoDownloadUrl))) return false;
            if (this.MarkableVideoDownloadUrl != input.MarkableVideoDownloadUrl || (this.MarkableVideoDownloadUrl != null && !this.MarkableVideoDownloadUrl.Equals(input.MarkableVideoDownloadUrl))) return false;
            if (this.TraningVideoMarkInfo != input.TraningVideoMarkInfo || (this.TraningVideoMarkInfo != null && !this.TraningVideoMarkInfo.Equals(input.TraningVideoMarkInfo))) return false;
            if (this.InferenceDataProcessVideoMarkInfo != input.InferenceDataProcessVideoMarkInfo || (this.InferenceDataProcessVideoMarkInfo != null && !this.InferenceDataProcessVideoMarkInfo.Equals(input.InferenceDataProcessVideoMarkInfo))) return false;
            if (this.InferenceDataProcessActionMarkInfo != input.InferenceDataProcessActionMarkInfo || (this.InferenceDataProcessActionMarkInfo != null && !this.InferenceDataProcessActionMarkInfo.Equals(input.InferenceDataProcessActionMarkInfo))) return false;
            if (this.InferenceDataProcessChatActionMarkInfo != input.InferenceDataProcessChatActionMarkInfo || (this.InferenceDataProcessChatActionMarkInfo != null && !this.InferenceDataProcessChatActionMarkInfo.Equals(input.InferenceDataProcessChatActionMarkInfo))) return false;
            if (this.InferenceDataProcessEyeCorrectionMarkInfo != input.InferenceDataProcessEyeCorrectionMarkInfo || (this.InferenceDataProcessEyeCorrectionMarkInfo != null && !this.InferenceDataProcessEyeCorrectionMarkInfo.Equals(input.InferenceDataProcessEyeCorrectionMarkInfo))) return false;
            if (this.IsBackgroundReplacement != input.IsBackgroundReplacement || (this.IsBackgroundReplacement != null && !this.IsBackgroundReplacement.Equals(input.IsBackgroundReplacement))) return false;
            if (this.WorkerType != input.WorkerType || (this.WorkerType != null && input.WorkerType != null && !this.WorkerType.SequenceEqual(input.WorkerType))) return false;
            if (this.VoiceTrainJobId != input.VoiceTrainJobId || (this.VoiceTrainJobId != null && !this.VoiceTrainJobId.Equals(input.VoiceTrainJobId))) return false;
            if (this.FlexusRetryCount != input.FlexusRetryCount || (this.FlexusRetryCount != null && !this.FlexusRetryCount.Equals(input.FlexusRetryCount))) return false;
            if (this.AudioSourceType != input.AudioSourceType) return false;
            if (this.SupportedService != input.SupportedService || (this.SupportedService != null && input.SupportedService != null && !this.SupportedService.SequenceEqual(input.SupportedService))) return false;
            if (this.AllocatedResource != input.AllocatedResource || (this.AllocatedResource != null && !this.AllocatedResource.Equals(input.AllocatedResource))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CoverDownloadUrl != null) hashCode = hashCode * 59 + this.CoverDownloadUrl.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Contact != null) hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.BatchName != null) hashCode = hashCode * 59 + this.BatchName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.ModelVersion.GetHashCode();
                hashCode = hashCode * 59 + this.MattingType.GetHashCode();
                if (this.ModelResolution != null) hashCode = hashCode * 59 + this.ModelResolution.GetHashCode();
                if (this.AppUserId != null) hashCode = hashCode * 59 + this.AppUserId.GetHashCode();
                if (this.IsFlexus != null) hashCode = hashCode * 59 + this.IsFlexus.GetHashCode();
                if (this.IsOnlyHumanModel != null) hashCode = hashCode * 59 + this.IsOnlyHumanModel.GetHashCode();
                if (this.TrainingVideoDownloadUrl != null) hashCode = hashCode * 59 + this.TrainingVideoDownloadUrl.GetHashCode();
                if (this.IdCardImage1DownloadUrl != null) hashCode = hashCode * 59 + this.IdCardImage1DownloadUrl.GetHashCode();
                if (this.IdCardImage2DownloadUrl != null) hashCode = hashCode * 59 + this.IdCardImage2DownloadUrl.GetHashCode();
                if (this.GrantFileDownloadUrl != null) hashCode = hashCode * 59 + this.GrantFileDownloadUrl.GetHashCode();
                if (this.PreBeautyImageDownloadUrl != null) hashCode = hashCode * 59 + this.PreBeautyImageDownloadUrl.GetHashCode();
                if (this.ActionVideoDownloadUrl != null) hashCode = hashCode * 59 + this.ActionVideoDownloadUrl.GetHashCode();
                if (this.PostBeautyImageDownloadUrl != null) hashCode = hashCode * 59 + this.PostBeautyImageDownloadUrl.GetHashCode();
                if (this.AudioFileDownloadUrl != null) hashCode = hashCode * 59 + this.AudioFileDownloadUrl.GetHashCode();
                if (this.OperationLogs != null) hashCode = hashCode * 59 + this.OperationLogs.GetHashCode();
                if (this.VerifyVideoMattingInfo != null) hashCode = hashCode * 59 + this.VerifyVideoMattingInfo.GetHashCode();
                if (this.CommentLogs != null) hashCode = hashCode * 59 + this.CommentLogs.GetHashCode();
                if (this.Samples != null) hashCode = hashCode * 59 + this.Samples.GetHashCode();
                if (this.IsMaskFileUploaded != null) hashCode = hashCode * 59 + this.IsMaskFileUploaded.GetHashCode();
                if (this.MaskFileDownloadUrl != null) hashCode = hashCode * 59 + this.MaskFileDownloadUrl.GetHashCode();
                if (this.VerifyVideoDownloadUrl != null) hashCode = hashCode * 59 + this.VerifyVideoDownloadUrl.GetHashCode();
                if (this.MarkableVideoDownloadUrl != null) hashCode = hashCode * 59 + this.MarkableVideoDownloadUrl.GetHashCode();
                if (this.TraningVideoMarkInfo != null) hashCode = hashCode * 59 + this.TraningVideoMarkInfo.GetHashCode();
                if (this.InferenceDataProcessVideoMarkInfo != null) hashCode = hashCode * 59 + this.InferenceDataProcessVideoMarkInfo.GetHashCode();
                if (this.InferenceDataProcessActionMarkInfo != null) hashCode = hashCode * 59 + this.InferenceDataProcessActionMarkInfo.GetHashCode();
                if (this.InferenceDataProcessChatActionMarkInfo != null) hashCode = hashCode * 59 + this.InferenceDataProcessChatActionMarkInfo.GetHashCode();
                if (this.InferenceDataProcessEyeCorrectionMarkInfo != null) hashCode = hashCode * 59 + this.InferenceDataProcessEyeCorrectionMarkInfo.GetHashCode();
                if (this.IsBackgroundReplacement != null) hashCode = hashCode * 59 + this.IsBackgroundReplacement.GetHashCode();
                if (this.WorkerType != null) hashCode = hashCode * 59 + this.WorkerType.GetHashCode();
                if (this.VoiceTrainJobId != null) hashCode = hashCode * 59 + this.VoiceTrainJobId.GetHashCode();
                if (this.FlexusRetryCount != null) hashCode = hashCode * 59 + this.FlexusRetryCount.GetHashCode();
                hashCode = hashCode * 59 + this.AudioSourceType.GetHashCode();
                if (this.SupportedService != null) hashCode = hashCode * 59 + this.SupportedService.GetHashCode();
                if (this.AllocatedResource != null) hashCode = hashCode * 59 + this.AllocatedResource.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
