/*************************************************************************************//*
*  ����: �޺���                                                                       *
*  ʱ��: 2021-04-18                                                                   *
*  �汾: master_482d3f                                                                *
*  ����:                                                                              *
*   - ��resource ���ر��ģ����                                                       *
*//************************************************************************************/

using System.Collections;

namespace UFrame.TableCfg
{
    public class AsyncTableOperation : IEnumerator
    {
        public bool finished { get; private set; }
        public event System.Action onFinish;
        public object Current => null;

        public bool MoveNext()
        {
            return !finished;
        }
        public void Reset()
        {
            finished = false;
            onFinish = null;
        }
        public void SetFinish()
        {
            finished = true;
            onFinish?.Invoke();
        }
    }
}
