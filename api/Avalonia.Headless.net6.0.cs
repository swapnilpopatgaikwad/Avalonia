//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     GenAPI Version: 7.0.8.6004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Avalonia.Headless
{
    public static partial class AvaloniaHeadlessPlatform
    {
        public static void ForceRenderTimerTick(int count = 1) { }
    }
    public static partial class AvaloniaHeadlessPlatformExtensions
    {
        public static Avalonia.AppBuilder UseHeadless(this Avalonia.AppBuilder builder, Avalonia.Headless.AvaloniaHeadlessPlatformOptions opts) { throw null; }
    }
    public partial class AvaloniaHeadlessPlatformOptions
    {
        public AvaloniaHeadlessPlatformOptions() { }
        public bool UseHeadlessDrawing { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=false)]
    public sealed partial class AvaloniaTestApplicationAttribute : System.Attribute
    {
        public AvaloniaTestApplicationAttribute([System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.NonPublicMethods | System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicMethods | System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] System.Type appBuilderEntryPointType) { }
        public System.Type AppBuilderEntryPointType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
    }
    [Avalonia.Metadata.UnstableAttribute("This API is experimental and might be unstable. Use on your risk. API might or might not be changed in a minor update.")]
    public sealed partial class HeadlessUnitTestSession : System.IDisposable
    {
        internal HeadlessUnitTestSession() { }
        public System.Threading.Tasks.Task Dispatch(System.Action action, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<TResult> Dispatch<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> action, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task<TResult> Dispatch<TResult>(System.Func<TResult> action, System.Threading.CancellationToken cancellationToken) { throw null; }
        public void Dispose() { }
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessageAttribute("Trimming", "IL2072", Justification="AvaloniaTestApplicationAttribute attribute should preserve type information.")]
        public static Avalonia.Headless.HeadlessUnitTestSession GetOrStartForAssembly(System.Reflection.Assembly? assembly) { throw null; }
        public static Avalonia.Headless.HeadlessUnitTestSession StartNew([System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.NonPublicMethods | System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicMethods | System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] System.Type entryPointType) { throw null; }
    }
    public static partial class HeadlessWindowExtensions
    {
        public static Avalonia.Media.Imaging.WriteableBitmap? CaptureRenderedFrame(this Avalonia.Controls.TopLevel topLevel) { throw null; }
        public static void DragDrop(this Avalonia.Controls.TopLevel topLevel, Avalonia.Point point, Avalonia.Input.Raw.RawDragEventType type, Avalonia.Input.IDataObject data, Avalonia.Input.DragDropEffects effects, Avalonia.Input.RawInputModifiers modifiers = Avalonia.Input.RawInputModifiers.None) { }
        public static Avalonia.Media.Imaging.WriteableBitmap? GetLastRenderedFrame(this Avalonia.Controls.TopLevel topLevel) { throw null; }
        public static void KeyPress(this Avalonia.Controls.TopLevel topLevel, Avalonia.Input.Key key, Avalonia.Input.RawInputModifiers modifiers) { }
        public static void KeyRelease(this Avalonia.Controls.TopLevel topLevel, Avalonia.Input.Key key, Avalonia.Input.RawInputModifiers modifiers) { }
        public static void MouseDown(this Avalonia.Controls.TopLevel topLevel, Avalonia.Point point, Avalonia.Input.MouseButton button, Avalonia.Input.RawInputModifiers modifiers = Avalonia.Input.RawInputModifiers.None) { }
        public static void MouseMove(this Avalonia.Controls.TopLevel topLevel, Avalonia.Point point, Avalonia.Input.RawInputModifiers modifiers = Avalonia.Input.RawInputModifiers.None) { }
        public static void MouseUp(this Avalonia.Controls.TopLevel topLevel, Avalonia.Point point, Avalonia.Input.MouseButton button, Avalonia.Input.RawInputModifiers modifiers = Avalonia.Input.RawInputModifiers.None) { }
        public static void MouseWheel(this Avalonia.Controls.TopLevel topLevel, Avalonia.Point point, Avalonia.Vector delta, Avalonia.Input.RawInputModifiers modifiers = Avalonia.Input.RawInputModifiers.None) { }
    }
}
