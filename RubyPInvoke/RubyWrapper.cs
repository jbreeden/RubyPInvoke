// ------------------------------------------------------------------
// DO NOT EDIT THIS FILE DIRECTLY
// ------------------------------------------------------------------
// This file is generated by the "ruby_wrapper.rb" script in
// the Scripts/ directory. Any changes made here will be overwritten.
// ------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace RubyPInvoke
{
   // Considered, and tried, SWIG to generate this wrapper.
   // The result were undesirable. PInvoke offers some nice
   // features, like translating ref parameters -> pointer
   // arguments, delegates -> function pointers, etc. The
   // interface generated by SWIG out of the box was not so
   // friendly. Rather than tediously maintaining SWIG
   // input files, I've decided - for now - to tedious
   // maintain this PInvoke wrapper.
   //
   // The contents here are generated by a custom script
   // (Scripts/scrape_headers.rb)

   public delegate IntPtr Callback(IntPtr ptr);
   public delegate void UnblockingFunction(IntPtr ptr);

   public unsafe class RubyWrapper
   {
      // Can't determine a way to specify the DLL name dynamically.
      // May have to have separate versions of this library for each
      // ruby DLL.
      //
      // Possible work-arounds
      //
      // - Installer finds & renames compatible DLLs
      // - Generate multiple Wrapper classes from a single master,
      //   and select the wrapper to delegate to at runtime.
      const string RUBY_DLL = "msvcrt-ruby200";


      // Casting
      // -------

      // VALUE rb_int2inum(SIGNED_VALUE)
      // Name:    rb_int2inum
      // Params:  (SIGNED_VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_int2inum(IntPtr signedValue0);

      // VALUE rb_uint2inum(VALUE)
      // Name:    rb_uint2inum
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_uint2inum(IntPtr value0);

      // VALUE rb_ll2inum(LONG_LONG)
      // Name:    rb_ll2inum
      // Params:  (LONG_LONG)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ll2inum(long longInteger0);

      // VALUE rb_ull2inum(unsigned LONG_LONG)
      // Name:    rb_ull2inum
      // Params:  (unsigned LONG_LONG)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ull2inum(ulong ulong0);

      // VALUE rb_string_value(volatile VALUE*)
      // Name:    rb_string_value
      // Params:  (volatile VALUE*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_string_value(IntPtr valuePtr);

      // char * rb_string_value_ptr(volatile VALUE*)
      // Name:    rb_string_value_ptr
      // Params:  (volatile VALUE*)
      // Return:  char *
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_string_value_ptr(IntPtr valuePtr);

      // char * rb_string_value_cstr(volatile VALUE*)
      // Name:    rb_string_value_cstr
      // Params:  (volatile VALUE*)
      // Return:  char *
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_string_value_cstr(IntPtr valuePtr);

      // SIGNED_VALUE rb_num2long(VALUE)
      // Name:    rb_num2long
      // Params:  (VALUE)
      // Return:  SIGNED_VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_num2long(IntPtr value0);

      // VALUE rb_num2ulong(VALUE)
      // Name:    rb_num2ulong
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_num2ulong(IntPtr value0);

      // long rb_num2int(VALUE)
      // Name:    rb_num2int
      // Params:  (VALUE)
      // Return:  long
      [DllImport(RUBY_DLL)]
      public static extern long rb_num2int(IntPtr value0);

      // long rb_fix2int(VALUE)
      // Name:    rb_fix2int
      // Params:  (VALUE)
      // Return:  long
      [DllImport(RUBY_DLL)]
      public static extern long rb_fix2int(IntPtr value0);

      // short rb_num2short(VALUE)
      // Name:    rb_num2short
      // Params:  (VALUE)
      // Return:  short
      [DllImport(RUBY_DLL)]
      public static extern short rb_num2short(IntPtr value0);

      // short rb_fix2short(VALUE)
      // Name:    rb_fix2short
      // Params:  (VALUE)
      // Return:  short
      [DllImport(RUBY_DLL)]
      public static extern short rb_fix2short(IntPtr value0);

      // LONG_LONG rb_num2ll(VALUE)
      // Name:    rb_num2ll
      // Params:  (VALUE)
      // Return:  LONG_LONG
      [DllImport(RUBY_DLL)]
      public static extern long rb_num2ll(IntPtr value0);

      // double rb_num2dbl(VALUE)
      // Name:    rb_num2dbl
      // Params:  (VALUE)
      // Return:  double
      [DllImport(RUBY_DLL)]
      public static extern double rb_num2dbl(IntPtr value0);

      // VALUE rb_uint2big(VALUE)
      // Name:    rb_uint2big
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_uint2big(IntPtr value0);

      // VALUE rb_int2big(SIGNED_VALUE)
      // Name:    rb_int2big
      // Params:  (SIGNED_VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_int2big(IntPtr signedValue0);

      // VALUE rb_id2str(ID)
      // Name:    rb_id2str
      // Params:  (ID)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_id2str(IntPtr id0);

      // Interacting
      // -----------

      // VALUE rb_define_class(const char*, VALUE)
      // Name:    rb_define_class
      // Params:  (const char*, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_define_class([MarshalAs(UnmanagedType.LPStr)] string string0, IntPtr value1);

      // VALUE rb_define_module(const char*)
      // Name:    rb_define_module
      // Params:  (const char*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_define_module([MarshalAs(UnmanagedType.LPStr)] string string0);

      // VALUE rb_define_class_under(VALUE, const char*, VALUE)
      // Name:    rb_define_class_under
      // Params:  (VALUE, const char*, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_define_class_under(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1, IntPtr value2);

      // VALUE rb_define_module_under(VALUE, const char*)
      // Name:    rb_define_module_under
      // Params:  (VALUE, const char*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_define_module_under(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1);

      // VALUE rb_gvar_undef_getter(ID id, void *data, struct rb_global_variable *gvar)
      // Name:    rb_gvar_undef_getter
      // Params:  (ID id, void *data, struct rb_global_variable *gvar)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_gvar_undef_getter(IntPtr id0, IntPtr voidPtr1, IntPtr globalVariable2);

      // void rb_gvar_undef_setter(VALUE val, ID id, void *data, struct rb_global_variable *gvar)
      // Name:    rb_gvar_undef_setter
      // Params:  (VALUE val, ID id, void *data, struct rb_global_variable *gvar)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_gvar_undef_setter(IntPtr value0, IntPtr id1, IntPtr voidPtr2, IntPtr globalVariable3);

      // void rb_gvar_undef_marker(VALUE *var)
      // Name:    rb_gvar_undef_marker
      // Params:  (VALUE *var)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_gvar_undef_marker(IntPtr value0);

      // VALUE rb_gvar_val_getter(ID id, void *data, struct rb_global_variable *gvar)
      // Name:    rb_gvar_val_getter
      // Params:  (ID id, void *data, struct rb_global_variable *gvar)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_gvar_val_getter(IntPtr id0, IntPtr voidPtr1, IntPtr globalVariable2);

      // void rb_gvar_val_setter(VALUE val, ID id, void *data, struct rb_global_variable *gvar)
      // Name:    rb_gvar_val_setter
      // Params:  (VALUE val, ID id, void *data, struct rb_global_variable *gvar)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_gvar_val_setter(IntPtr value0, IntPtr id1, IntPtr voidPtr2, IntPtr globalVariable3);

      // void rb_gvar_val_marker(VALUE *var)
      // Name:    rb_gvar_val_marker
      // Params:  (VALUE *var)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_gvar_val_marker(IntPtr value0);

      // VALUE rb_gvar_var_getter(ID id, void *data, struct rb_global_variable *gvar)
      // Name:    rb_gvar_var_getter
      // Params:  (ID id, void *data, struct rb_global_variable *gvar)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_gvar_var_getter(IntPtr id0, IntPtr voidPtr1, IntPtr globalVariable2);

      // void rb_gvar_var_setter(VALUE val, ID id, void *data, struct rb_global_variable *gvar)
      // Name:    rb_gvar_var_setter
      // Params:  (VALUE val, ID id, void *data, struct rb_global_variable *gvar)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_gvar_var_setter(IntPtr value0, IntPtr id1, IntPtr voidPtr2, IntPtr globalVariable3);

      // void rb_gvar_var_marker(VALUE *var)
      // Name:    rb_gvar_var_marker
      // Params:  (VALUE *var)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_gvar_var_marker(IntPtr value0);

      // void rb_gvar_readonly_setter(VALUE val, ID id, void *data, struct rb_global_variable *gvar)
      // Name:    rb_gvar_readonly_setter
      // Params:  (VALUE val, ID id, void *data, struct rb_global_variable *gvar)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_gvar_readonly_setter(IntPtr value0, IntPtr id1, IntPtr voidPtr2, IntPtr globalVariable3);

      // void rb_define_variable(const char*, VALUE*)
      // Name:    rb_define_variable
      // Params:  (const char*, VALUE*)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_variable([MarshalAs(UnmanagedType.LPStr)] string string0, IntPtr value1);

      // void rb_define_virtual_variable(const char*, VALUE(*)(ANYARGS), void(*)(ANYARGS))
      // Name:    rb_define_virtual_variable
      // Params:  (const char*, VALUE(*)(ANYARGS), void(*)(ANYARGS))
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_virtual_variable([MarshalAs(UnmanagedType.LPStr)] string string0, Callback callback1, Callback callback2);

      // void rb_define_hooked_variable(const char*, VALUE*, VALUE(*)(ANYARGS), void(*)(ANYARGS))
      // Name:    rb_define_hooked_variable
      // Params:  (const char*, VALUE*, VALUE(*)(ANYARGS), void(*)(ANYARGS))
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_hooked_variable([MarshalAs(UnmanagedType.LPStr)] string string0, IntPtr value1, Callback callback2, Callback callback3);

      // void rb_define_readonly_variable(const char*, VALUE*)
      // Name:    rb_define_readonly_variable
      // Params:  (const char*, VALUE*)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_readonly_variable([MarshalAs(UnmanagedType.LPStr)] string string0, IntPtr value1);

      // void rb_define_const(VALUE, const char*, VALUE)
      // Name:    rb_define_const
      // Params:  (VALUE, const char*, VALUE)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_const(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1, IntPtr value2);

      // void rb_define_global_const(const char*, VALUE)
      // Name:    rb_define_global_const
      // Params:  (const char*, VALUE)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_global_const([MarshalAs(UnmanagedType.LPStr)] string string0, IntPtr value1);

      // void rb_define_method(VALUE, const char*, VALUE(*)(ANYARGS), int)
      // Name:    rb_define_method
      // Params:  (VALUE, const char*, VALUE(*)(ANYARGS), int)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_method(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1, Callback callback2, int integer3);

      // void rb_define_module_function(VALUE, const char*, VALUE(*)(ANYARGS), int)
      // Name:    rb_define_module_function
      // Params:  (VALUE, const char*, VALUE(*)(ANYARGS), int)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_module_function(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1, Callback callback2, int integer3);

      // void rb_define_global_function(const char*, VALUE(*)(ANYARGS), int)
      // Name:    rb_define_global_function
      // Params:  (const char*, VALUE(*)(ANYARGS), int)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_global_function([MarshalAs(UnmanagedType.LPStr)] string string0, Callback callback1, int integer2);

      // void rb_define_alias(VALUE, const char*, const char*)
      // Name:    rb_define_alias
      // Params:  (VALUE, const char*, const char*)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_alias(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1, [MarshalAs(UnmanagedType.LPStr)] string string2);

      // void rb_define_attr(VALUE, const char*, int, int)
      // Name:    rb_define_attr
      // Params:  (VALUE, const char*, int, int)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_define_attr(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1, int integer2, int integer3);

      // VALUE rb_eval_string(const char*)
      // Name:    rb_eval_string
      // Params:  (const char*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_eval_string([MarshalAs(UnmanagedType.LPStr)] string string0);

      // VALUE rb_eval_string_protect(const char*, int*)
      // Name:    rb_eval_string_protect
      // Params:  (const char*, int*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_eval_string_protect([MarshalAs(UnmanagedType.LPStr)] string string0, ref int intRef1);

      // VALUE rb_eval_string_wrap(const char*, int*)
      // Name:    rb_eval_string_wrap
      // Params:  (const char*, int*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_eval_string_wrap([MarshalAs(UnmanagedType.LPStr)] string string0, ref int intRef1);

      // VALUE rb_funcall(VALUE, ID, int, ...)
      // Name:    rb_funcall
      // Params:  (VALUE, ID, int, ...)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_funcall(IntPtr value0, IntPtr id1, int integer2, object varargs);

      // VALUE rb_funcall2(VALUE, ID, int, const VALUE*)
      // Name:    rb_funcall2
      // Params:  (VALUE, ID, int, const VALUE*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_funcall2(IntPtr value0, IntPtr id1, int integer2, IntPtr value3);

      // VALUE rb_funcall3(VALUE, ID, int, const VALUE*)
      // Name:    rb_funcall3
      // Params:  (VALUE, ID, int, const VALUE*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_funcall3(IntPtr value0, IntPtr id1, int integer2, IntPtr value3);

      // VALUE rb_funcall_passing_block(VALUE, ID, int, const VALUE*)
      // Name:    rb_funcall_passing_block
      // Params:  (VALUE, ID, int, const VALUE*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_funcall_passing_block(IntPtr value0, IntPtr id1, int integer2, IntPtr value3);

      // VALUE rb_funcall_with_block(VALUE, ID, int, const VALUE*, VALUE)
      // Name:    rb_funcall_with_block
      // Params:  (VALUE, ID, int, const VALUE*, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_funcall_with_block(IntPtr value0, IntPtr id1, int integer2, IntPtr value3, IntPtr value4);

      // VALUE rb_gv_set(const char*, VALUE)
      // Name:    rb_gv_set
      // Params:  (const char*, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_gv_set([MarshalAs(UnmanagedType.LPStr)] string string0, IntPtr value1);

      // VALUE rb_gv_get(const char*)
      // Name:    rb_gv_get
      // Params:  (const char*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_gv_get([MarshalAs(UnmanagedType.LPStr)] string string0);

      // VALUE rb_iv_get(VALUE, const char*)
      // Name:    rb_iv_get
      // Params:  (VALUE, const char*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_iv_get(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1);

      // VALUE rb_iv_set(VALUE, const char*, VALUE)
      // Name:    rb_iv_set
      // Params:  (VALUE, const char*, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_iv_set(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1, IntPtr value2);

      // VALUE rb_singleton_class(VALUE)
      // Name:    rb_singleton_class
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_singleton_class(IntPtr value0);

      // VALUE rb_protect(VALUE (*)(VALUE), VALUE, int*)
      // Name:    rb_protect
      // Params:  (VALUE (*)(VALUE), VALUE, int*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_protect(Callback callback0, IntPtr value1, ref int intRef2);

      // VALUE rb_const_list(void*)
      // Name:    rb_const_list
      // Params:  (void*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_const_list(IntPtr voidPtr0);

      // int rb_const_defined(VALUE, ID)
      // Name:    rb_const_defined
      // Params:  (VALUE, ID)
      // Return:  int
      [DllImport(RUBY_DLL)]
      public static extern int rb_const_defined(IntPtr value0, IntPtr id1);

      // int rb_const_defined_at(VALUE, ID)
      // Name:    rb_const_defined_at
      // Params:  (VALUE, ID)
      // Return:  int
      [DllImport(RUBY_DLL)]
      public static extern int rb_const_defined_at(IntPtr value0, IntPtr id1);

      // int rb_const_defined_from(VALUE, ID)
      // Name:    rb_const_defined_from
      // Params:  (VALUE, ID)
      // Return:  int
      [DllImport(RUBY_DLL)]
      public static extern int rb_const_defined_from(IntPtr value0, IntPtr id1);

      // VALUE rb_const_get(VALUE, ID)
      // Name:    rb_const_get
      // Params:  (VALUE, ID)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_const_get(IntPtr value0, IntPtr id1);

      // VALUE rb_const_get_at(VALUE, ID)
      // Name:    rb_const_get_at
      // Params:  (VALUE, ID)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_const_get_at(IntPtr value0, IntPtr id1);

      // VALUE rb_const_get_from(VALUE, ID)
      // Name:    rb_const_get_from
      // Params:  (VALUE, ID)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_const_get_from(IntPtr value0, IntPtr id1);

      // void rb_const_set(VALUE, ID, VALUE)
      // Name:    rb_const_set
      // Params:  (VALUE, ID, VALUE)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_const_set(IntPtr value0, IntPtr id1, IntPtr value2);

      // VALUE rb_const_remove(VALUE, ID)
      // Name:    rb_const_remove
      // Params:  (VALUE, ID)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_const_remove(IntPtr value0, IntPtr id1);

      // Interns
      // -------

      // ID rb_intern(const char*)
      // Name:    rb_intern
      // Params:  (const char*)
      // Return:  ID
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_intern([MarshalAs(UnmanagedType.LPStr)] string string0);

      // ID rb_intern2(const char*, long)
      // Name:    rb_intern2
      // Params:  (const char*, long)
      // Return:  ID
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_intern2([MarshalAs(UnmanagedType.LPStr)] string string0, long longInteger1);

      // ID rb_intern_str(VALUE str)
      // Name:    rb_intern_str
      // Params:  (VALUE str)
      // Return:  ID
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_intern_str(IntPtr value0);

      // Initializing
      // ------------

      // void ruby_sysinit(int *argc, char ***argv)
      // Name:    ruby_sysinit
      // Params:  (int *argc, char ***argv)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void ruby_sysinit(ref int argc, string[] argv);

      // void ruby_init(void)
      // Name:    ruby_init
      // Params:  (void)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void ruby_init();

      // void ruby_init_stack(volatile VALUE*, void*)
      // Name:    ruby_init_stack
      // Params:  (volatile VALUE*, void*)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void ruby_init_stack(IntPtr valuePtr, IntPtr voidPtr1);

      // void ruby_init_stack(volatile VALUE*)
      // Name:    ruby_init_stack
      // Params:  (volatile VALUE*)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void ruby_init_stack(IntPtr valuePtr);

      // void ruby_prog_init(void)
      // Name:    ruby_prog_init
      // Params:  (void)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void ruby_prog_init();

      // void ruby_init_loadpath(void)
      // Name:    ruby_init_loadpath
      // Params:  (void)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void ruby_init_loadpath();

      // Threading
      // ---------

      // void * rb_thread_call_with_gvl(void *(*func)(void *), void *data1)
      // Name:    rb_thread_call_with_gvl
      // Params:  (void *(*func)(void *), void *data1)
      // Return:  void *
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_thread_call_with_gvl(Callback callback0, IntPtr voidPtr1);

      // void * rb_thread_call_without_gvl(void *(*func)(void *), void *data1, rb_unblock_function_t *ubf, void *data2)
      // Name:    rb_thread_call_without_gvl
      // Params:  (void *(*func)(void *), void *data1, rb_unblock_function_t *ubf, void *data2)
      // Return:  void *
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_thread_call_without_gvl(Callback callback0, IntPtr voidPtr1, UnblockingFunction ubf, IntPtr voidPtr3);

      // void * rb_thread_call_without_gvl2(void *(*func)(void *), void *data1, rb_unblock_function_t *ubf, void *data2)
      // Name:    rb_thread_call_without_gvl2
      // Params:  (void *(*func)(void *), void *data1, rb_unblock_function_t *ubf, void *data2)
      // Return:  void *
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_thread_call_without_gvl2(Callback callback0, IntPtr voidPtr1, UnblockingFunction ubf, IntPtr voidPtr3);

      // VALUE rb_thread_create(VALUE (*)(ANYARGS), void*)
      // Name:    rb_thread_create
      // Params:  (VALUE (*)(ANYARGS), void*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_thread_create(Callback callback0, IntPtr voidPtr1);

      // Arrays
      // ------

      // VALUE rb_ary_new(void)
      // Name:    rb_ary_new
      // Params:  (void)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_new();

      // VALUE rb_ary_new2(long)
      // Name:    rb_ary_new2
      // Params:  (long)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_new2(long longInteger0);

      // VALUE rb_ary_new3(long, ...)
      // Name:    rb_ary_new3
      // Params:  (long, ...)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_new3(long longInteger0, object varargs);

      // VALUE rb_ary_new4(long, const VALUE *)
      // Name:    rb_ary_new4
      // Params:  (long, const VALUE *)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_new4(long longInteger0, IntPtr value1);

      // VALUE rb_ary_tmp_new(long)
      // Name:    rb_ary_tmp_new
      // Params:  (long)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_tmp_new(long longInteger0);

      // void rb_ary_free(VALUE)
      // Name:    rb_ary_free
      // Params:  (VALUE)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_ary_free(IntPtr value0);

      // void rb_ary_modify(VALUE)
      // Name:    rb_ary_modify
      // Params:  (VALUE)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_ary_modify(IntPtr value0);

      // VALUE rb_ary_freeze(VALUE)
      // Name:    rb_ary_freeze
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_freeze(IntPtr value0);

      // VALUE rb_ary_shared_with_p(VALUE, VALUE)
      // Name:    rb_ary_shared_with_p
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_shared_with_p(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_aref(int, VALUE*, VALUE)
      // Name:    rb_ary_aref
      // Params:  (int, VALUE*, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_aref(int integer0, IntPtr value1, IntPtr value2);

      // VALUE rb_ary_subseq(VALUE, long, long)
      // Name:    rb_ary_subseq
      // Params:  (VALUE, long, long)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_subseq(IntPtr value0, long longInteger1, long longInteger2);

      // void rb_ary_store(VALUE, long, VALUE)
      // Name:    rb_ary_store
      // Params:  (VALUE, long, VALUE)
      // Return:  void
      [DllImport(RUBY_DLL)]
      public static extern void rb_ary_store(IntPtr value0, long longInteger1, IntPtr value2);

      // VALUE rb_ary_dup(VALUE)
      // Name:    rb_ary_dup
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_dup(IntPtr value0);

      // VALUE rb_ary_resurrect(VALUE ary)
      // Name:    rb_ary_resurrect
      // Params:  (VALUE ary)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_resurrect(IntPtr value0);

      // VALUE rb_ary_to_ary(VALUE)
      // Name:    rb_ary_to_ary
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_to_ary(IntPtr value0);

      // VALUE rb_ary_to_s(VALUE)
      // Name:    rb_ary_to_s
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_to_s(IntPtr value0);

      // VALUE rb_ary_push(VALUE, VALUE)
      // Name:    rb_ary_push
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_push(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_pop(VALUE)
      // Name:    rb_ary_pop
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_pop(IntPtr value0);

      // VALUE rb_ary_shift(VALUE)
      // Name:    rb_ary_shift
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_shift(IntPtr value0);

      // VALUE rb_ary_unshift(VALUE, VALUE)
      // Name:    rb_ary_unshift
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_unshift(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_entry(VALUE, long)
      // Name:    rb_ary_entry
      // Params:  (VALUE, long)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_entry(IntPtr value0, long longInteger1);

      // VALUE rb_ary_each(VALUE)
      // Name:    rb_ary_each
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_each(IntPtr value0);

      // VALUE rb_ary_join(VALUE, VALUE)
      // Name:    rb_ary_join
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_join(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_reverse(VALUE)
      // Name:    rb_ary_reverse
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_reverse(IntPtr value0);

      // VALUE rb_ary_rotate(VALUE, long)
      // Name:    rb_ary_rotate
      // Params:  (VALUE, long)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_rotate(IntPtr value0, long longInteger1);

      // VALUE rb_ary_sort(VALUE)
      // Name:    rb_ary_sort
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_sort(IntPtr value0);

      // VALUE rb_ary_sort_bang(VALUE)
      // Name:    rb_ary_sort_bang
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_sort_bang(IntPtr value0);

      // VALUE rb_ary_delete(VALUE, VALUE)
      // Name:    rb_ary_delete
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_delete(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_delete_at(VALUE, long)
      // Name:    rb_ary_delete_at
      // Params:  (VALUE, long)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_delete_at(IntPtr value0, long longInteger1);

      // VALUE rb_ary_clear(VALUE)
      // Name:    rb_ary_clear
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_clear(IntPtr value0);

      // VALUE rb_ary_plus(VALUE, VALUE)
      // Name:    rb_ary_plus
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_plus(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_concat(VALUE, VALUE)
      // Name:    rb_ary_concat
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_concat(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_assoc(VALUE, VALUE)
      // Name:    rb_ary_assoc
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_assoc(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_rassoc(VALUE, VALUE)
      // Name:    rb_ary_rassoc
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_rassoc(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_includes(VALUE, VALUE)
      // Name:    rb_ary_includes
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_includes(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_cmp(VALUE, VALUE)
      // Name:    rb_ary_cmp
      // Params:  (VALUE, VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_cmp(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_replace(VALUE copy, VALUE orig)
      // Name:    rb_ary_replace
      // Params:  (VALUE copy, VALUE orig)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_replace(IntPtr value0, IntPtr value1);

      // VALUE rb_ary_resize(VALUE ary, long len)
      // Name:    rb_ary_resize
      // Params:  (VALUE ary, long len)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_ary_resize(IntPtr value0, long longInteger1);

      // Strings
      // -------

      // VALUE rb_str_new(const char*, long)
      // Name:    rb_str_new
      // Params:  (const char*, long)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_str_new([MarshalAs(UnmanagedType.LPStr)] string string0, long longInteger1);

      // VALUE rb_str_new_cstr(const char*)
      // Name:    rb_str_new_cstr
      // Params:  (const char*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_str_new_cstr([MarshalAs(UnmanagedType.LPStr)] string string0);

      // VALUE rb_str_new2(const char*)
      // Name:    rb_str_new2
      // Params:  (const char*)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_str_new2([MarshalAs(UnmanagedType.LPStr)] string string0);

      // VALUE rb_str_new_shared(VALUE)
      // Name:    rb_str_new_shared
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_str_new_shared(IntPtr value0);

      // VALUE rb_str_new3(VALUE)
      // Name:    rb_str_new3
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_str_new3(IntPtr value0);

      // VALUE rb_str_new_frozen(VALUE)
      // Name:    rb_str_new_frozen
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_str_new_frozen(IntPtr value0);

      // VALUE rb_str_new4(VALUE)
      // Name:    rb_str_new4
      // Params:  (VALUE)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_str_new4(IntPtr value0);

      // VALUE rb_str_new_with_class(VALUE, const char*, long)
      // Name:    rb_str_new_with_class
      // Params:  (VALUE, const char*, long)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_str_new_with_class(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1, long longInteger2);

      // VALUE rb_str_new5(VALUE, const char*, long)
      // Name:    rb_str_new5
      // Params:  (VALUE, const char*, long)
      // Return:  VALUE
      [DllImport(RUBY_DLL)]
      public static extern IntPtr rb_str_new5(IntPtr value0, [MarshalAs(UnmanagedType.LPStr)] string string1, long longInteger2);
   }
}
