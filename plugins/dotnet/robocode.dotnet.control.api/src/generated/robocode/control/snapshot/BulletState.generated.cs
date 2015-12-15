/**
 * Copyright (c) 2001-2016 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/epl-v10.html
 */
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.8669
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace robocode.control.snapshot {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class BulletState : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_values0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_valueOf1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getValue2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toState3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isActive4;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_FIRED5;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_MOVING6;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_HIT_VICTIM7;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_HIT_BULLET8;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_HIT_WALL9;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_EXPLODED10;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_INACTIVE11;
        
        protected BulletState(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.snapshot.BulletState.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/BulletState;")]
        public static global::robocode.control.snapshot.BulletState FIRED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.BulletState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_FIRED5));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/BulletState;")]
        public static global::robocode.control.snapshot.BulletState MOVING {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.BulletState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_MOVING6));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/BulletState;")]
        public static global::robocode.control.snapshot.BulletState HIT_VICTIM {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.BulletState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_HIT_VICTIM7));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/BulletState;")]
        public static global::robocode.control.snapshot.BulletState HIT_BULLET {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.BulletState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_HIT_BULLET8));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/BulletState;")]
        public static global::robocode.control.snapshot.BulletState HIT_WALL {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.BulletState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_HIT_WALL9));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/BulletState;")]
        public static global::robocode.control.snapshot.BulletState EXPLODED {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.BulletState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_EXPLODED10));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/BulletState;")]
        public static global::robocode.control.snapshot.BulletState INACTIVE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.BulletState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_INACTIVE11));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.snapshot.BulletState.staticClass = @__class;
            global::robocode.control.snapshot.BulletState.j4n_values0 = @__env.GetStaticMethodID(global::robocode.control.snapshot.BulletState.staticClass, "values", "()[Lrobocode/control/snapshot/BulletState;");
            global::robocode.control.snapshot.BulletState.j4n_valueOf1 = @__env.GetStaticMethodID(global::robocode.control.snapshot.BulletState.staticClass, "valueOf", "(Ljava/lang/String;)Lrobocode/control/snapshot/BulletState;");
            global::robocode.control.snapshot.BulletState.j4n_getValue2 = @__env.GetMethodID(global::robocode.control.snapshot.BulletState.staticClass, "getValue", "()I");
            global::robocode.control.snapshot.BulletState.j4n_toState3 = @__env.GetStaticMethodID(global::robocode.control.snapshot.BulletState.staticClass, "toState", "(I)Lrobocode/control/snapshot/BulletState;");
            global::robocode.control.snapshot.BulletState.j4n_isActive4 = @__env.GetMethodID(global::robocode.control.snapshot.BulletState.staticClass, "isActive", "()Z");
            global::robocode.control.snapshot.BulletState.j4n_FIRED5 = @__env.GetStaticFieldID(global::robocode.control.snapshot.BulletState.staticClass, "FIRED", "Lrobocode/control/snapshot/BulletState;");
            global::robocode.control.snapshot.BulletState.j4n_MOVING6 = @__env.GetStaticFieldID(global::robocode.control.snapshot.BulletState.staticClass, "MOVING", "Lrobocode/control/snapshot/BulletState;");
            global::robocode.control.snapshot.BulletState.j4n_HIT_VICTIM7 = @__env.GetStaticFieldID(global::robocode.control.snapshot.BulletState.staticClass, "HIT_VICTIM", "Lrobocode/control/snapshot/BulletState;");
            global::robocode.control.snapshot.BulletState.j4n_HIT_BULLET8 = @__env.GetStaticFieldID(global::robocode.control.snapshot.BulletState.staticClass, "HIT_BULLET", "Lrobocode/control/snapshot/BulletState;");
            global::robocode.control.snapshot.BulletState.j4n_HIT_WALL9 = @__env.GetStaticFieldID(global::robocode.control.snapshot.BulletState.staticClass, "HIT_WALL", "Lrobocode/control/snapshot/BulletState;");
            global::robocode.control.snapshot.BulletState.j4n_EXPLODED10 = @__env.GetStaticFieldID(global::robocode.control.snapshot.BulletState.staticClass, "EXPLODED", "Lrobocode/control/snapshot/BulletState;");
            global::robocode.control.snapshot.BulletState.j4n_INACTIVE11 = @__env.GetStaticFieldID(global::robocode.control.snapshot.BulletState.staticClass, "INACTIVE", "Lrobocode/control/snapshot/BulletState;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Lrobocode/control/snapshot/BulletState;")]
        public static robocode.control.snapshot.BulletState[] values() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<robocode.control.snapshot.BulletState[], global::robocode.control.snapshot.BulletState>(@__env, @__env.CallStaticObjectMethodPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_values0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Lrobocode/control/snapshot/BulletState;")]
        public static global::robocode.control.snapshot.BulletState valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.BulletState>(@__env, @__env.CallStaticObjectMethodPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_valueOf1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.snapshot.BulletState.j4n_getValue2)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Lrobocode/control/snapshot/BulletState;")]
        public static global::robocode.control.snapshot.BulletState toState(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.BulletState>(@__env, @__env.CallStaticObjectMethodPtr(global::robocode.control.snapshot.BulletState.staticClass, global::robocode.control.snapshot.BulletState.j4n_toState3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isActive() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::robocode.control.snapshot.BulletState.j4n_isActive4)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.snapshot.BulletState(@__env);
            }
        }
    }
    #endregion
}
