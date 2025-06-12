using System;


namespace Serialize
{
    public interface ISerialize
    {
        T? Load<T>();

        void Save<T>(T data);
    }
}