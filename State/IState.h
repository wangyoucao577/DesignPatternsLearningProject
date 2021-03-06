#pragma once

//定义有哪些状态, 以电梯做示例
enum class ElevatorState {
    kStopClosed = 0,
    kStopOpened,
    kStopOpening,
    kStopClosing,
    kRunning,
};

enum class ElevatorButtonAction {
    kClosePressed,
    kOpenPressed,
};


// 定义状态类的统一接口
class IState
{
public:
    virtual ~IState() = 0;  //纯虚析构, 必须有定义(函数体), 同样可以调用

    virtual ElevatorState Open() = 0;
    virtual ElevatorState Close() = 0;

    virtual ElevatorState curr_state() const = 0;
};

