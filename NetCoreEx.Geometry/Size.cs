﻿
using System;
using System.Runtime.InteropServices;
using System.Globalization;

namespace NetCoreEx.Geometry {

    [StructLayout(LayoutKind.Sequential)]
	public partial struct Size : IEquatable<Size>
	{

	    public Size(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public bool Equals(Size other)
        {
            return (this.Width == other.Width) && (this.Height == other.Height);
        }

        public override bool Equals(object obj)
        {
            return obj is Size && this.Equals((Size)obj);
        }

        public override int GetHashCode()
        {
            unchecked { return ((int)this.Width * 397) ^ (int)this.Height; }
        }

        public int Width;
        public int Height;

        public static bool operator ==(Size left, Size right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Size left, Size right)
        {
            return !(left == right);
        }

		public void Offset(int  width, int  height) {
			Width += width;
			Height += height;
		}

		public void Set(int  width, int  height) {
			Width = width;
			Height = height;
		}

		public override string ToString() {
			var culture = CultureInfo.CurrentCulture;
			return $"{{ Width = {Width.ToString(culture)}, Height = {Height.ToString(culture)} }}";
        }
		
		public bool IsEmpty => this.Width == 0 && this.Height == 0;
	}

    [StructLayout(LayoutKind.Sequential)]
	public partial struct SizeS : IEquatable<SizeS>
	{

	    public SizeS(short width, short height)
        {
            this.Width = width;
            this.Height = height;
        }

        public bool Equals(SizeS other)
        {
            return (this.Width == other.Width) && (this.Height == other.Height);
        }

        public override bool Equals(object obj)
        {
            return obj is SizeS && this.Equals((SizeS)obj);
        }

        public override int GetHashCode()
        {
            unchecked { return ((int)this.Width * 397) ^ (int)this.Height; }
        }

        public short Width;
        public short Height;

        public static bool operator ==(SizeS left, SizeS right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(SizeS left, SizeS right)
        {
            return !(left == right);
        }

		public void Offset(short  width, short  height) {
			Width += width;
			Height += height;
		}

		public void Set(short  width, short  height) {
			Width = width;
			Height = height;
		}

		public override string ToString() {
			var culture = CultureInfo.CurrentCulture;
			return $"{{ Width = {Width.ToString(culture)}, Height = {Height.ToString(culture)} }}";
        }
		
		public bool IsEmpty => this.Width == 0 && this.Height == 0;
	}

    [StructLayout(LayoutKind.Sequential)]
	public partial struct SizeF : IEquatable<SizeF>
	{

	    public SizeF(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public bool Equals(SizeF other)
        {
            return (this.Width == other.Width) && (this.Height == other.Height);
        }

        public override bool Equals(object obj)
        {
            return obj is SizeF && this.Equals((SizeF)obj);
        }

        public override int GetHashCode()
        {
            unchecked { return ((int)this.Width * 397) ^ (int)this.Height; }
        }

        public float Width;
        public float Height;

        public static bool operator ==(SizeF left, SizeF right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(SizeF left, SizeF right)
        {
            return !(left == right);
        }

		public void Offset(float  width, float  height) {
			Width += width;
			Height += height;
		}

		public void Set(float  width, float  height) {
			Width = width;
			Height = height;
		}

		public override string ToString() {
			var culture = CultureInfo.CurrentCulture;
			return $"{{ Width = {Width.ToString(culture)}, Height = {Height.ToString(culture)} }}";
        }
		
		public bool IsEmpty => this.Width == 0 && this.Height == 0;
	}

}
