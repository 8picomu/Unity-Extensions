using System;
using System.Collections.Generic;

namespace eightpicomu.Extensions {
    public interface IListWrapper<T> {
        List<T> List { get; set; }
    }

    /// <summary>
    /// 多次元配列のシリアライズのときに使用する
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class ListWrapper<T> {
        public List<T> List;
    }
}