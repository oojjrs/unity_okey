﻿using UnityEngine;

public class MyKeyPool : MonoBehaviour
{
    [SerializeField]
    private MyKeyPoolGamepad _gamepadPs;
    [SerializeField]
    private MyKeyPoolGamepad _gamepadXbox;
    [SerializeField]
    private MyKeyPoolKeyboard _keyboard;
    [SerializeField]
    private MyKeyPoolMouse _mouse;

    public Sprite GetSprite(string key)
    {
        return key switch
        {
            "<Gamepad>/buttonEast" => _gamepadXbox.ButtonEast,
            "<Gamepad>/buttonNorth" => _gamepadXbox.ButtonNorth,
            "<Gamepad>/buttonSouth" => _gamepadXbox.ButtonSouth,
            "<Gamepad>/buttonWest" => _gamepadXbox.ButtonWest,
            "<opad>/DPad" => _gamepadXbox.DPad,
            "<Gamepad>/dpad/down" => _gamepadXbox.DPadDown,
            "<Gamepad>/dpad/left" => _gamepadXbox.DPadLeft,
            "<Gamepad>/dpad/right" => _gamepadXbox.DPadRight,
            "<Gamepad>/dpad/up" => _gamepadXbox.DPadUp,
            "<Gamepad>/leftShoulder" => _gamepadXbox.LeftBumper,
            "<opad>/LeftStick" => _gamepadXbox.LeftStick,
            "<opad>/LeftStickMove" => _gamepadXbox.LeftStickMove,
            "<Gamepad>/leftStick/down" => _gamepadXbox.LeftStickDown,
            "<Gamepad>/leftStick/left" => _gamepadXbox.LeftStickLeft,
            "<Gamepad>/leftStick/right" => _gamepadXbox.LeftStickRight,
            "<Gamepad>/leftStick/up" => _gamepadXbox.LeftStickUp,
            "<Gamepad>/leftStickPress" => _gamepadXbox.LeftStickPress,
            "<Gamepad>/leftTrigger" => _gamepadXbox.LeftTrigger,
            "<Gamepad>/rightShoulder" => _gamepadXbox.RightBumper,
            "<opad>/RightStick" => _gamepadXbox.RightStick,
            "<opad>/RightStickMove" => _gamepadXbox.RightStickMove,
            "<Gamepad>/rightStick/down" => _gamepadXbox.RightStickDown,
            "<Gamepad>/rightStick/left" => _gamepadXbox.RightStickLeft,
            "<Gamepad>/rightStick/right" => _gamepadXbox.RightStickRight,
            "<Gamepad>/rightStick/up" => _gamepadXbox.RightStickUp,
            "<Gamepad>/rightStickPress" => _gamepadXbox.RightStickPress,
            "<Gamepad>/rightTrigger" => _gamepadXbox.RightTrigger,
            "<Gamepad>/select" => _gamepadXbox.Select,
            "<Gamepad>/start" => _gamepadXbox.Start,
            "<omouse>/Body" => _mouse.Body,
            "<Mouse>/leftButton" => _mouse.LeftButton,
            "<Mouse>/middleButton" => _mouse.MiddleButton,
            "<Mouse>/rightButton" => _mouse.RightButton,
            "<omouse>/Direction" => _mouse.Direction,
            "<omouse>/DirectionDown" => _mouse.DirectionDown,
            "<omouse>/DirectionLeft" => _mouse.DirectionLeft,
            "<omouse>/DirectionRight" => _mouse.DirectionRight,
            "<omouse>/DirectionUp" => _mouse.DirectionUp,
            "<omouse>/WheelDown" => _mouse.WheelDown,
            "<omouse>/WheelMove" => _mouse.WheelMove,
            "<omouse>/WheelUp" => _mouse.WheelUp,
            "<Keyboard>/escape" => _keyboard.Escape,
            "<Keyboard>/f1" => _keyboard.F1,
            "<Keyboard>/f2" => _keyboard.F2,
            "<Keyboard>/f3" => _keyboard.F3,
            "<Keyboard>/f4" => _keyboard.F4,
            "<Keyboard>/f5" => _keyboard.F5,
            "<Keyboard>/f6" => _keyboard.F6,
            "<Keyboard>/f7" => _keyboard.F7,
            "<Keyboard>/f8" => _keyboard.F8,
            "<Keyboard>/f9" => _keyboard.F9,
            "<Keyboard>/f10" => _keyboard.F10,
            "<Keyboard>/f11" => _keyboard.F11,
            "<Keyboard>/f12" => _keyboard.F12,
            "<Keyboard>/printScreen" => _keyboard.PrintScreen,
            "<Keyboard>/scrollLock" => _keyboard.ScrollLock,
            "<Keyboard>/pause" => _keyboard.Pause,
            "<Keyboard>/backquote" or "<Keyboard>/#(`)" => _keyboard.Backtick,
            "<okey>/Tilde" => _keyboard.Tilde,
            "<Keyboard>/1" or "<Keyboard>/#(1)" => _keyboard._1,
            "<okey>/ExclamationMark" => _keyboard.ExclamationMark,
            "<Keyboard>/2" or "<Keyboard>/#(2)" => _keyboard._2,
            "<okey>/At" => _keyboard.At,
            "<Keyboard>/3" or "<Keyboard>/#(3)" => _keyboard._3,
            "<okey>/NumberSign" => _keyboard.NumberSign,
            "<Keyboard>/4" or "<Keyboard>/#(4)" => _keyboard._4,
            "<okey>/DollarSign" => _keyboard.DollarSign,
            "<Keyboard>/5" or "<Keyboard>/#(5)" => _keyboard._5,
            "<okey>/PercentSign" => _keyboard.PercentSign,
            "<Keyboard>/6" or "<Keyboard>/#(6)" => _keyboard._6,
            "<okey>/Caret" => _keyboard.Caret,
            "<Keyboard>/7" or "<Keyboard>/#(7)" => _keyboard._7,
            "<okey>/Ampersand" => _keyboard.Ampersand,
            "<Keyboard>/8" or "<Keyboard>/#(8)" => _keyboard._8,
            "<okey>/Asterisk" or "<Keyboard>/#(*)" => _keyboard.Asterisk,
            "<Keyboard>/9" or "<Keyboard>/#(9)" => _keyboard._9,
            "<okey>/ParenthesisLeft" => _keyboard.ParenthesisLeft,
            "<Keyboard>/0" or "<Keyboard>/#(0)" => _keyboard._0,
            "<okey>/ParenthesisRight" => _keyboard.ParenthesisRight,
            "<Keyboard>/minus" or "<Keyboard>/#(-)" => _keyboard.Minus,
            "<okey>/LowLine" => _keyboard.LowLine,
            "<Keyboard>/equals" or "<Keyboard>/#(=)" => _keyboard._Equals,
            "<okey>/Plus" or "<Keyboard>/#(+)" => _keyboard.Plus,
            "<Keyboard>/backslash" or "<Keyboard>/#(\\)" => _keyboard.Backslash,
            "<okey>/VerticalBar" => _keyboard.VerticalBar,
            "<Keyboard>/tab" => _keyboard.Tab,
            "<Keyboard>/enter" => _keyboard.Enter,
            "<Keyboard>/space" => _keyboard.Space,
            "<Keyboard>/quote" or "<Keyboard>/#(')" => _keyboard.SingleQuotation,
            "<okey>/DoubleQuotation" => _keyboard.DoubleQuotation,
            "<Keyboard>/semicolon" or "<Keyboard>/#(;)" => _keyboard.Semicolon,
            "<okey>/Colon" => _keyboard.Colon,
            "<Keyboard>/comma" or "<Keyboard>/#(,)" => _keyboard.Comma,
            "<okey>/AngleBracketLeft" => _keyboard.AngleBracketLeft,
            "<Keyboard>/period" or "<Keyboard>/#(.)" => _keyboard.Dot,
            "<okey>/AngleBracketRight" => _keyboard.AngleBracketRight,
            "<Keyboard>/slash" or "<Keyboard>/#(/)" => _keyboard.Slash,
            "<Keyboard>/leftBracket" or "<Keyboard>/#([)" => _keyboard.BracketLeft,
            "<okey>/CurlyBracketLeft" => _keyboard.CurlyBracketLeft,
            "<Keyboard>/rightBracket" or "<Keyboard>/#(])" => _keyboard.BracketRight,
            "<okey>/CurlyBracketRight" => _keyboard.CurlyBracketRight,
            "<Keyboard>/a" or "<Keyboard>/#(A)" => _keyboard.A,
            "<Keyboard>/b" or "<Keyboard>/#(B)" => _keyboard.B,
            "<Keyboard>/c" or "<Keyboard>/#(C)" => _keyboard.C,
            "<Keyboard>/d" or "<Keyboard>/#(D)" => _keyboard.D,
            "<Keyboard>/e" or "<Keyboard>/#(E)" => _keyboard.E,
            "<Keyboard>/f" or "<Keyboard>/#(F)" => _keyboard.F,
            "<Keyboard>/g" or "<Keyboard>/#(G)" => _keyboard.G,
            "<Keyboard>/h" or "<Keyboard>/#(H)" => _keyboard.H,
            "<Keyboard>/i" or "<Keyboard>/#(I)" => _keyboard.I,
            "<Keyboard>/j" or "<Keyboard>/#(J)" => _keyboard.J,
            "<Keyboard>/k" or "<Keyboard>/#(K)" => _keyboard.K,
            "<Keyboard>/l" or "<Keyboard>/#(L)" => _keyboard.L,
            "<Keyboard>/m" or "<Keyboard>/#(M)" => _keyboard.M,
            "<Keyboard>/n" or "<Keyboard>/#(N)" => _keyboard.N,
            "<Keyboard>/o" or "<Keyboard>/#(O)" => _keyboard.O,
            "<Keyboard>/p" or "<Keyboard>/#(P)" => _keyboard.P,
            "<Keyboard>/q" or "<Keyboard>/#(Q)" => _keyboard.Q,
            "<Keyboard>/r" or "<Keyboard>/#(R)" => _keyboard.R,
            "<Keyboard>/s" or "<Keyboard>/#(S)" => _keyboard.S,
            "<Keyboard>/t" or "<Keyboard>/#(T)" => _keyboard.T,
            "<Keyboard>/u" or "<Keyboard>/#(U)" => _keyboard.U,
            "<Keyboard>/v" or "<Keyboard>/#(V)" => _keyboard.V,
            "<Keyboard>/w" or "<Keyboard>/#(W)" => _keyboard.W,
            "<Keyboard>/x" or "<Keyboard>/#(X)" => _keyboard.X,
            "<Keyboard>/y" or "<Keyboard>/#(Y)" => _keyboard.Y,
            "<Keyboard>/z" or "<Keyboard>/#(Z)" => _keyboard.Z,
            "<Keyboard>/upArrow" => _keyboard.ArrowUp,
            "<Keyboard>/downArrow" => _keyboard.ArrowDown,
            "<Keyboard>/leftArrow" => _keyboard.ArrowLeft,
            "<Keyboard>/rightArrow" => _keyboard.ArrowRight,
            "<okey>/a" => _keyboard.a,
            "<okey>/b" => _keyboard.b,
            "<okey>/c" => _keyboard.c,
            "<okey>/d" => _keyboard.d,
            "<okey>/e" => _keyboard.e,
            "<okey>/f" => _keyboard.f,
            "<okey>/g" => _keyboard.g,
            "<okey>/h" => _keyboard.h,
            "<okey>/i" => _keyboard.i,
            "<okey>/j" => _keyboard.j,
            "<okey>/k" => _keyboard.k,
            "<okey>/l" => _keyboard.l,
            "<okey>/m" => _keyboard.m,
            "<okey>/n" => _keyboard.n,
            "<okey>/o" => _keyboard.o,
            "<okey>/p" => _keyboard.p,
            "<okey>/q" => _keyboard.q,
            "<okey>/r" => _keyboard.r,
            "<okey>/s" => _keyboard.s,
            "<okey>/t" => _keyboard.t,
            "<okey>/u" => _keyboard.u,
            "<okey>/v" => _keyboard.v,
            "<okey>/w" => _keyboard.w,
            "<okey>/x" => _keyboard.x,
            "<okey>/y" => _keyboard.y,
            "<okey>/z" => _keyboard.z,
            "<Keyboard>/shift" => _keyboard.Shift,
            "<Keyboard>/leftShift" => _keyboard.ShiftLeft,
            "<Keyboard>/rightShift" => _keyboard.ShiftRight,
            "<Keyboard>/alt" => _keyboard.Alt,
            "<Keyboard>/leftAlt" => _keyboard.AltLeft,
            "<Keyboard>/rightAlt" => _keyboard.AltRight,
            "<Keyboard>/ctrl" => _keyboard.Ctrl,
            "<Keyboard>/leftCtrl" => _keyboard.CtrlLeft,
            "<Keyboard>/rightCtrl" => _keyboard.CtrlRight,
            "<okey>/meta" => _keyboard.Windows,
            "<Keyboard>/leftMeta" => _keyboard.WindowsLeft,
            "<Keyboard>/rightMeta" => _keyboard.WindowsRight,
            "<Keyboard>/contextMenu" => _keyboard.ContextMenu,
            "<Keyboard>/backspace" => _keyboard.Backspace,
            "<Keyboard>/pageDown" => _keyboard.PageDown,
            "<Keyboard>/pageUp" => _keyboard.PageUp,
            "<Keyboard>/home" => _keyboard.Home,
            "<Keyboard>/end" => _keyboard.End,
            "<Keyboard>/insert" => _keyboard.Insert,
            "<Keyboard>/delete" => _keyboard.Delete,
            "<Keyboard>/capsLock" => _keyboard.CapsLock,
            "<Keyboard>/numLock" => _keyboard.NumLock,
            "<Keyboard>/numpadEnter" => _keyboard.NumpadEnter,
            "<Keyboard>/numpadDivide" => _keyboard.NumpadSlash,
            "<Keyboard>/numpadMultiply" => _keyboard.NumpadAsterisk,
            "<Keyboard>/numpadPlus" => _keyboard.NumpadPlus,
            "<Keyboard>/numpadMinus" => _keyboard.NumpadMinus,
            "<Keyboard>/numpadPeriod" => _keyboard.NumpadDot,
            "<Keyboard>/numpadEquals" => _keyboard._Equals,
            "<Keyboard>/numpad1" => _keyboard.Numpad1,
            "<Keyboard>/numpad2" => _keyboard.Numpad2,
            "<Keyboard>/numpad3" => _keyboard.Numpad3,
            "<Keyboard>/numpad4" => _keyboard.Numpad4,
            "<Keyboard>/numpad5" => _keyboard.Numpad5,
            "<Keyboard>/numpad6" => _keyboard.Numpad6,
            "<Keyboard>/numpad7" => _keyboard.Numpad7,
            "<Keyboard>/numpad8" => _keyboard.Numpad8,
            "<Keyboard>/numpad9" => _keyboard.Numpad9,
            "<Keyboard>/numpad0" => _keyboard.Numpad0,
            "<Keyboard>/OEM1" => _keyboard.Null,
            "<Keyboard>/OEM2" => _keyboard.Null,
            "<Keyboard>/OEM3" => _keyboard.Null,
            "<Keyboard>/OEM4" => _keyboard.Null,
            "<Keyboard>/OEM5" => _keyboard.Null,
            "<Keyboard>/lang1" => _keyboard.Lang1,
            "<Keyboard>/lang2" => _keyboard.Lang2,
            "<Keyboard>/muhenkan" => _keyboard.Muhenkan,
            "<Keyboard>/henkan" => _keyboard.Henkan,
            "<Keyboard>/kana" => _keyboard.Kana,
            _ => _keyboard.Null,
        };
    }
}
