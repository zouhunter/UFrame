/*************************************************************************************//*
*  作者: 邹杭特                                                                       *
*  时间: 2021-04-18                                                                   *
*  版本: master_482d3f                                                                *
*  功能:                                                                              *
*   - 刷新接口                                                                        *
*//************************************************************************************/

namespace UFrame
{
    public interface IUpdate : IInterval
    {
        void OnUpdate();
    }
}