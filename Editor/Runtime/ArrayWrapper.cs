using System;

namespace eightpicomu.Extensions {
    public interface IArrayWrapper<T> {
        T[] Array { get; set; }
    }

    /// <summary>
    /// 多次元配列のシリアライズのときに使用する
    /// </summary>
    [Serializable]
    public class BoolArrayWrapper {
        public bool[] Array;
    }
}