using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace dz4
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xdoc= new XmlDocument();
            
            XmlDeclaration XmlDec = xdoc.CreateXmlDeclaration("1.0", "WINDOWS-1251", null);
            ///<sammary>
            /// Корневой элемент Xml документа
            /// </sammary>
            XmlElement root = xdoc.CreateElement("Market");
            xdoc.AppendChild(root);


            ///<sammary>
            /// Список продуктов в магазине
            /// </sammary>
            XmlElement products = xdoc.CreateElement("Products");
            root.AppendChild(products);

            ///<sammary>
            /// Категория продуктов
            /// </sammary>
            XmlElement category = xdoc.CreateElement("Category");
            category.InnerText = "Бензин";
            products.AppendChild(category);

            ///<sammary>
            /// Товар
            /// </sammary>
            XmlElement tovar = xdoc.CreateElement("Tovar");
            category.AppendChild(tovar);

            ///<sammary>
            /// Название товара
            /// </sammary>
            XmlElement name = xdoc.CreateElement("Name");
            name.InnerText = "Бензин 92";
            tovar.AppendChild(name);

            ///<sammary>
            /// Цена товара
            /// </sammary>
            XmlElement price = xdoc.CreateElement("Price");
            price.InnerText = "120";
            tovar.AppendChild(price);





            //---------------------------------
            ///<sammary>
            /// Категория продуктов
            /// </sammary>
            XmlElement c = xdoc.CreateElement("Category");
            c.InnerText = "Вредная еда";
            products.AppendChild(c);
            ///<sammary>
            /// Товар
            /// </sammary>
            XmlElement t = xdoc.CreateElement("Tovar");
            c.AppendChild(t);
            ///<sammary>
            /// Название товара
            /// </sammary>
            XmlElement nameP = xdoc.CreateElement("Name");
            nameP.InnerText = "Чипсы";
            t.AppendChild(nameP);
            ///<sammary>
            /// Цена товара
            /// </sammary>
            XmlElement p = xdoc.CreateElement("Price");
            p.InnerText = "200";
            t.AppendChild(p);
            ///<sammary>
            /// Код товара
            /// </sammary>
            XmlElement code = xdoc.CreateElement("Code");
            code.InnerText = "156161512";
            t.AppendChild(code);




            //---------------------------------
            ///<sammary>
            /// Категория продуктов
            /// </sammary>
            XmlElement ct = xdoc.CreateElement("Category");
            ct.InnerText = "Одежда";
            ///<sammary>
            /// Товар
            /// </sammary>
            products.AppendChild(ct);
            XmlElement to = xdoc.CreateElement("Tovar");
            ///<sammary>
            /// Название товара
            /// </sammary>
            ct.AppendChild(to);
            XmlElement nam = xdoc.CreateElement("Name");
            nam.InnerText = "Кофта";
            to.AppendChild(nam);
            ///<sammary>
            /// Цена товара
            /// </sammary>
            XmlElement pr = xdoc.CreateElement("Price");
            pr.InnerText = "1200";
            to.AppendChild(pr);
            ///<sammary>
            /// Код товара
            /// </sammary>
            XmlElement cd = xdoc.CreateElement("Code");
            cd.InnerText = "15642156";
            to.AppendChild(cd);
            ///<sammary>
            /// Цвет товара
            /// </sammary>
            XmlElement color = xdoc.CreateElement("Color");
            color.InnerText = "Red";
            to.AppendChild(color);
            ///<sammary>
            /// Размер товара
            /// </sammary>
            XmlElement size = xdoc.CreateElement("Size");
            size.InnerText = "S";
            to.AppendChild(size);
            ///<sammary>
            /// Материал товара
            /// </sammary>
            XmlElement material = xdoc.CreateElement("Material");
            material.InnerText = "Sintetic";
            to.AppendChild(material);



            //-----------------------------------
            ///<sammary>
            /// Категория продуктов
            /// </sammary>
            XmlElement l = xdoc.CreateElement("Category");
            l.InnerText = "Мебель";
            products.AppendChild(l);
            ///<sammary>
            /// Название товара
            /// </sammary>

            XmlElement tv = xdoc.CreateElement("Tovar");
            l.AppendChild(tv);
            XmlElement d = xdoc.CreateElement("Name");
            d.InnerText = "Диван";
            tv.AppendChild(d);
            ///<sammary>
            /// Цена товара
            /// </sammary>
            XmlElement o = xdoc.CreateElement("Price");
            o.InnerText = "120000";
            tv.AppendChild(o);
            ///<sammary>
            /// Код товара
            /// </sammary>
            XmlElement cod = xdoc.CreateElement("Code");
            cod.InnerText = "487462564";
            tv.AppendChild(cod);
            ///<sammary>
            /// Цвет товара
            /// </sammary>
            XmlElement col = xdoc.CreateElement("Color");
            col.InnerText = "Blue";
            tv.AppendChild(col);
            ///<sammary>
            /// Размер товара
            /// </sammary>
            XmlElement sz = xdoc.CreateElement("Size");
            XmlElement width = xdoc.CreateElement("Width");
            width.InnerText = "120";
            sz.AppendChild(width);
            XmlElement heigt = xdoc.CreateElement("Height");
            heigt.InnerText = "30";
            sz.AppendChild(heigt);
            tv.AppendChild(sz);
            ///<sammary>
            /// Материал товара
            /// </sammary>
            XmlElement mat = xdoc.CreateElement("Material");
            mat.InnerText = "Bamboo";
            tv.AppendChild(mat);

            //----------------------------------------

            ///<sammary>
            /// Категория продуктов
            /// </sammary>
            XmlElement tec = xdoc.CreateElement("Category");
            tec.InnerText = "Техника";
            products.AppendChild(tec);
            ///<sammary>
            /// Категория продуктов
            /// </sammary>
            XmlElement pos = xdoc.CreateElement("Category");
            pos.InnerText = "Посуда";
            products.AppendChild(pos);

            ///<sammary>
            /// Категория продуктов
            /// </sammary>
            XmlElement fru = xdoc.CreateElement("Category");
            fru.InnerText = "Фрукты";
            products.AppendChild(fru);

            ///<sammary>
            /// Категория продуктов
            /// </sammary>
            XmlElement ins = xdoc.CreateElement("Category");
            ins.InnerText = "Инструменты";
            products.AppendChild(ins);



            ///<sammary>
            /// Категория продуктов
            /// </sammary>
            XmlElement mu = xdoc.CreateElement("Category");
            mu.InnerText = "Мучное";
            products.AppendChild(mu);


            xdoc.Save("Products.xml");
        }
    }
}
