namespace Stanford.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Stanford.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Stanford.Context.QuestionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Stanford.Context.QuestionContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            
            context.Questions.AddOrUpdate(
                    p => p.Id,
                    new Question { Id = 1, Q = "����Ҫ���һ���죬���", A = "�ƻ���Ҫ��ʲô����ʲôʱ����", B = "˵ȥ��ȥ" },
                    new Question { Id = 2, Q = "����Ϊ�Լ���һ��", A = "��Ϊ������������", B = "��Ϊ���������" },
                    new Question { Id = 3, Q = "��������һλ��ʦ�����ѡ��", A = "����ʵΪ���Ŀγ�", B = "�漰���۵Ŀγ�" },
                    new Question { Id = 4, Q = "��ͨ��", A = "�������׻���", B = "�Ƚϳ��������" },
                    new Question { Id = 5, Q = "һ����˵�������Щ�˱ȽϺϵ�����", A = "��������������", B = "��ʵ����" },
                    new Question { Id = 6, Q = "���Ƿ񾭳���", A = "������֧���������", B = "�����������������" },
                    new Question { Id = 7, Q = "�����������������", A = "ƾ����������", B = "���ռƻ�����" },
                    new Question { Id = 8, Q = "���Ƿ�", A = "���������˽�", B = "���������˽�" },
                    new Question { Id = 9, Q = "���ճ��������", A = "��������", B = "����е�����" },
                    new Question { Id = 10,Q = "������һ���ر���������ϲ��", A = "��ʼǰС����֯�ƻ�", B = "������������ʲô" },
                    new Question { Id = 11,Q = "�ڴ��������£����ѡ��", A = "˳����Ȼ", B = "�����������" },
                    new Question { Id = 12,Q = "������˻�˵����һ��", A = "����������˽����", B = "�ǳ�̹�ʿ��ŵ���" },
                    new Question { Id = 13,Q = "����Ը������Ϊ��һ��", A = "ʵ�����ǵ���", B = "�������" },
                    new Question { Id = 14,Q = "��һ��Ⱥ�˵��У�ͨ����", A = "����ܴ����ʶ", B = "���˽�����" },
                    new Question { Id = 15,Q = "������Щ��������", A = "�������ע���", B = "��̤ʵ�ص�" },
                    new Question { Id = 16,Q = "������", A = "���Ӹ�������߼�", B = "�����߼����ڸ���" },
                    new Question { Id = 17,Q = "��Ƚ�ϲ��", A = "�������鷢չ�����ƻ�", B = "��������ƻ�" },
                    new Question { Id = 18,Q = "��ϲ�����ܶ��ʱ��", A = "һ���˶���", B = "�ϱ�����һ��" },
                    new Question { Id = 19,Q = "��ܶ���һ���", A = "�����������", B = "��������������" },
                    new Question { Id = 20,Q = "��Ƚ�ϲ��", A = "������Լ�ᡢ�罻�ۼ������鰲���׵�", B = "�޾�����������ʱ��ʲô�������ʲô" },
                    new Question { Id = 21,Q = "�ƻ�һ���ó�ʱ�����ϲ��", A = "�󲿷ֵ�ʱ�䶼�Ǹ�����ĸо�����", B = "����֪���󲿷ֵ����ӻ���ʲô" },
                    new Question { Id = 22,Q = "���罻�ۻ��У���", A = "��ʱ�е�����", B = "������������" },
                    new Question { Id = 23,Q = "��ͨ��", A = "�ͱ������׻���", B = "�����Դ�һ��" },
                    new Question { Id = 24,Q = "��Щ�˻�������㣿", A = "һ��˼�����ݼ��ǳ���ӱ����", B = "b1ʵ�����ǣ��߷ḻ��ʶ����" },
                    new Question { Id = 25,Q = "���ճ������У����", A = "��Ϊϲ��������ʹ����������ͻ��", B = "ͨ��Ԥ�ȼƻ�������Ҫ��ѹ���¹���" },
                    new Question { Id = 26, Q = "����Ϊ����һ��", A = "Ҫ���ܳ�ʱ�����ʶ��", B = "�ú̵ܶ�ʱ�����ʶ��" },
                    new Question { Id = 27, Q = "��һ��������������⣿", A = "ע����˽", B = "̹�ʿ���" },
                    new Question { Id = 28, Q = "��һ��������������⣿", A = "Ԥ�Ȱ��ŵ�", B = "�޼ƻ���" },
                    new Question { Id = 29, Q = "��һ��������������⣿", A = "����", B = "����" },
                    new Question { Id = 30, Q = "��һ��������������⣿", A = "����", B = "�ᶨ" },
                    new Question { Id = 31, Q = "��һ��������������⣿", A = "˼��", B = "����" },
                    new Question { Id = 32, Q = "��һ��������������⣿", A = "��ʵ", B = "����" },
                    new Question { Id = 33, Q = "��һ��������������⣿", A = "�嶯", B = "����" },
                    new Question { Id = 34, Q = "��һ��������������⣿", A = "����", B = "�ľ�" },
                    new Question { Id = 35, Q = "��һ��������������⣿", A = "�ľ�", B = "����" },
                    new Question { Id = 36, Q = "��һ��������������⣿", A = "��ϵͳ", B = "����" },
                    new Question { Id = 37, Q = "��һ��������������⣿", A = "����", B = "�϶�" },
                    new Question { Id = 38, Q = "��һ��������������⣿", A = "����", B = "����" },
                    new Question { Id = 39, Q = "��һ��������������⣿", A = "�����ŷ�", B = "���˵�" },
                    new Question { Id = 40, Q = "��һ��������������⣿", A = "����", B = "����" },
                    new Question { Id = 41, Q = "��һ��������������⣿", A = "����Լ��", B = "Ԥ�Ȱ���" },
                    new Question { Id = 42, Q = "��һ��������������⣿", A = "���", B = "��̸" },
                    new Question { Id = 43, Q = "��һ��������������⣿", A = "��������", B = "����С��" },
                    new Question { Id = 44, Q = "��һ��������������⣿", A = "����", B = "ʵ��" },
                    new Question { Id = 45, Q = "��һ��������������⣿", A = "ͬ������", B = "Զ��" },
                    new Question { Id = 46, Q = "��һ��������������⣿", A = "����", B = "ף��" },
                    new Question { Id = 47, Q = "��һ��������������⣿", A = "��ʵ��", B = "���۵�" },
                    new Question { Id = 48, Q = "��һ��������������⣿", A = "���Ѳ���", B = "�����ڶ�" },
                    new Question { Id = 49, Q = "��һ��������������⣿", A = "��ϵͳ", B = "����" },
                    new Question { Id = 50, Q = "��һ��������������⣿", A = "�������", B = "��������" },
                    new Question { Id = 51, Q = "��һ��������������⣿", A = "���е�", B = "�͹۵�" },
                    new Question { Id = 52, Q = "��һ��������������⣿", A = "�͹۵�", B = "�����" },
                    new Question { Id = 53, Q = "��һ��������������⣿", A = "����", B = "����" },
                    new Question { Id = 54, Q = "��һ��������������⣿", A = "�ľ�", B = "����Ⱥ" },
                    new Question { Id = 55, Q = "��һ��������������⣿", A = "����", B = "��ʵ" },
                    new Question { Id = 56, Q = "��һ��������������⣿", A = "��ͬ��", B = "���߼�" },
                    new Question { Id = 57, Q = "��һ��������������⣿", A = "�߷�����", B = "����Ƹ�" },
                    new Question { Id = 58, Q = "��һ��������������⣿", A = "�������", B = "��������" },
                    new Question { Id = 59, Q = "����Ҫ��һ�����������һ������Ŀ�����ڿ�ʼ��ʱ���", A = "��Ҫ���Ĳ�ͬ���������г�", B = "���϶���" },
                    new Question { Id = 60, Q = "���罻�����У��㾭����е�", A = "��ĳЩ�˺��Ѵ򿪻�ϻ���ͱ��ֶԻ�", B = "������˶��ܴ��ݵس�̸" },
                    new Question { Id = 61, Q = "Ҫ�������Ҳ�����£���Ƚ�ϲ��", A = "����һ���Ͽɵķ���ȥ��", B = "����һ���Լ����뷨" },
                    new Question { Id = 62, Q = "�����ʶ�������ܷ�˵�������Ȥ��", A = "���Ͽ���", B = "Ҫ�����������˽���֮��ſ���" },
                    new Question { Id = 63, Q = "��ͨ����ϲ���Ŀ�Ŀ��", A = "���ڸ����ԭ���", B = "������ʵ�����ݵ�" },
                    new Question { Id = 64, Q = "�ĸ��ǽϸߵ������������Ϊ��", A = "һ����Ե���", B = "һ�����Ե���" },
                    new Question { Id = 65, Q = "����Ϊ���ճ��������", A = "��ʱ����Ҫ�ģ���һ����˵�㲻��ϲ��������������", B = "�������������а�����������ϲ������" },
                    new Question { Id = 66, Q = "��һȺ����һ����ͨ����ѡ", A = "�������Ϥ�ĸ�����̸��", B = "�������̸��" },
                    new Question { Id = 67, Q = "���罻�ۻ��ϣ����", A = "��˵���ܶ��һ��", B = "�ñ��˶�˵��" },
                    new Question { Id = 68, Q = "����ĩ�ڼ�Ҫ��ɵ����г��嵥����������", A = "������", B = "ʹ���᲻��" },
                    new Question { Id = 69, Q = "�ĸ��ǽϸߵ������������Ϊ", A = "�ܸɵ�", B = "����ͬ����" },
                    new Question { Id = 70, Q = "��ͨ��ϲ��", A = "���Ȱ�������罻Լ��", B = "����֮��������" },
                    new Question { Id = 71, Q = "�ܵ�˵����Ҫ��һ��������ҵʱ�����ѡ", A = "�����������ʲô", B = "���Ȱѹ�������ϸ��" },
                    new Question { Id = 72, Q = "���ܷ����ϲ�������������", A = "ֻ���ڸ����й�ͬ��Ȥ����", B = "�������κ��˶�����" },
                    new Question { Id = 73, Q = "���", A = "����һЩ֤����Ч�ķ���������", B = "��������ʲôë�����������δ���������" },
                    new Question { Id = 74, Q = "Ϊ��Ȥ���Ķ�ʱ�����", A = "ϲ�����ػ��µı�﷽ʽ", B = "ϲ������ֱ��ֱ˵" },
                    new Question { Id = 75, Q = "����Ը����һ����˾��������ʦ��������", A = "���Դ�����������ǰ��һ��", B = "�Դʼ�����Զ�Ϻ��߼���" },
                    new Question { Id = 76, Q = "�����¶�����", A = "����������ȥ��", B = "����õĳ����ȥ��" },
                    new Question { Id = 77, Q = "���Ƿ�", A = "���Ժ��κ��˰�������ݵؽ�̸������", B = "ֻ�Ƕ�ĳЩ�˻���ĳ������²ſ��Գ�������" },
                    new Question { Id = 78, Q = "Ҫ������ʱ������Ϊ�Ƚ���Ҫ����", A = "����ʵ����", B = "�������˵ĸ��ܺ����" },
                    new Question { Id = 79, Q = "��һ��������������⣿", A = "�����", B = "��ʵ��" },
                    new Question { Id = 80, Q = "��һ��������������⣿", A = "�ʴȿ�����", B = "��־�ᶨ��" },
                    new Question { Id = 81, Q = "��һ��������������⣿", A = "������", B = "�йػ���" },
                    new Question { Id = 82, Q = "��һ��������������⣿", A = "����", B = "���" },
                    new Question { Id = 83, Q = "��һ��������������⣿", A = "������", B = "��Ȼ��" },
                    new Question { Id = 84, Q = "��һ��������������⣿", A = "����", B = "����" },
                    new Question { Id = 85, Q = "��һ��������������⣿", A = "ʵ��", B = "����Ƹ�" },
                    new Question { Id = 86, Q = "��һ��������������⣿", A = "����", B = "����" },
                    new Question { Id = 87, Q = "��һ��������������⣿", A = "��ӱ��", B = "��֪��" },
                    new Question { Id = 88, Q = "��һ��������������⣿", A = "ͬ��", B = "����" },
                    new Question { Id = 89, Q = "��һ��������������⣿", A = "��ּ���", B = "�����а���" },
                    new Question { Id = 90, Q = "��һ��������������⣿", A = "�����", B = "�����" }, 
                    new Question { Id = 91, Q = "��һ��������������⣿", A = "ȫ��Ͷ��", B = "�о��ĵ�" },
                    new Question { Id = 92, Q = "��һ��������������⣿", A = "�ܸ�", B = "�ʴ�" },
                    new Question { Id = 93, Q = "��һ��������������⣿", A = "ʵ��", B = "����" }
                );



            List<Major> majors = new List<Major>();
            //majors.Add(new Major("Physics"));
            //majors.Add(new Major("Maths"));
            //majors.Add(new Major("Chemistry"));
            ChrTrait INFJ = new ChrTrait(1, "INFJ", "Physics,Maths,Chemistry");

            context.Traits.AddOrUpdate(
                p=>p.Id,
                INFJ
                );


        }
    }
}
