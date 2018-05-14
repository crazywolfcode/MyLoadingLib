# MyLoadingLib

1. 下载Dll

       https://pan.baidu.com/s/1wKgv5_Q8phWo5CrXWlB9dA

2.在项目中添加引用

        略

3.在Xaml中引入名称空间

      xmlns:myLib="clr-namespace:MyLoadingLib;assembly=MyLoadingLib"

4.使用代码

     <StackPanel>
     <myLib:CirclePointRingLoading Width="40" Height="40" IsActive="True" IsLarge="False" Foreground="#3ca9fe"/>
                    <TextBlock Foreground="#787978" FontSize="13" Text="正在检测新版本..."  Padding="10,15,0,0"/>
                    <myLib:HorizontalPoingLoading FillBrush="#3ca9fe" EllipseDiameter="10"/>
                    <myLib:ThreePoingLoading Foreground="#3ca9fe" Margin="0,20,0,0" />
                    <myLib:TwoPointLoading EllipseWidth="16" Foreground="#3ca9fe" />
                    <myLib:OnePointLoading Foreground="#3ca9fe" Margin="5"/>
                    <myLib:RadnerLoading Foreground="#1ab394"/>
                   
                    <myLib:GridLoading Foreground="#3ca9fe" />
                    <myLib:FiveColumnLoading Foreground="#3ca9fe" />
                    <myLib:IconLoading Foreground="#3ca9fe" IconSize="30" Icon="&#xe62e;"/>
                    <myLib:IconLoading Foreground="#3ca9fe" IconSize="30" Icon="&#xe623;"/>
                    <myLib:IconLoading Foreground="#3ca9fe" IconSize="30" Icon="&#xe770;"/>

    </StackPanel>    


5.    效果
<img src="https://img-blog.csdn.net/20180514173432909" alt="">

虽然不是那么的全面 ，希望能帮助到更多的朋友
