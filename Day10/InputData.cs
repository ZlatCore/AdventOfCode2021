﻿namespace Day10
{
    public class InputData
    {

        public static string[] GetTestInput()
        {
            return new string[]
                {
                    "[({(<(())[]>[[{[]{<()<>>",
"[(()[<>])]({[<{<<[]>>(",
"{([(<{}[<>[]}>{[]{[(<()>",
"(((({<>}<{<{<>}{[]{[]{}",
"[[<[([]))<([[{}[[()]]]",
"[{[{({}]{}}([{[{{{}}([]",
"{<[[]]>}<{[{[{[]{()[[[]",
"[<(<(<(<{}))><([]([]()",
"<{([([[(<>()){}]>(<<{{",
"<{([{{}}[<[[[<>{}]]]>[]]"
                };
        }

        public static string[] GetInput()
        {
            return new string[]
                {
                    "<([<({{[<{{((<()>({}{})}<({}<>)>)}}>[<{(([()<>]<<>{}>))}<{({<>[]}<<>>)[([]<>)<{}{}>]}>>]]}}[<[{{[{{[<><>]",
"[<{{{[((({<<<[()[]]{()()}><{<><>}(<>{})>><<{<><>}{{}[]}>{(()())[[]{}]}>>{[[(<>[]){<>{}}][(()())(()[])]]",
"(((<{<[[<[{(((<><>)[{}{}]){{{}<>}[()<>]})(([<>()][<>{}]){{[]()}})}[({([][])<{}<>>}{[[]<>]{()",
"[(<{<[<<<<[[{<[]()><<>()>}[{{}<>}<()>]]<<[[]{}]>{({}())}>]((((<>())<(){}>)<{[]{}}<(){}>>)[{[[]<>]<[",
"[[{(<{<<[{(<({<>{}}<()[]>){<<>[]>{<>}}><[[()[]]]{{()<>}{()<>}}])[{[(<>())]<<[]{}>(<>[])>}<[{",
"(<<<[[<{({<<([{}{}](<><>)){{<><>}(())}>{<{(){}}{[][]}>[{[][]}([]())]}><([{{}[]}[[]{}]](<[]{}><{}<>>))((<(){",
"<<<{((<<{[([<[[]{}]([][])>{[<>()][[][]]}]<<[()[]][[]{}]>[<<><>>(<><>)]>)<({{{}<>}{{}}}{{<><",
"{[(<[{{{<[{({([]{}){{}{}}}[({}<>)])[([()[]]<[]{}>)<[{}{}]{{}()}>]}(<{{{}<>}(()[])}>{{<()<>><[]<>>}",
"[<<{({[{((({<<<><>>(()())>{{[][]}<{}()>}}[[((){})[{}()]]<[()<>]>]){{(<{}<>>[()<>]){{[][]}(()<>",
"({[([([<(<<[{<<><>>({}())}[[(){}][[][]]]]>><<(({<><>}{[][]})<{()()}[[]<>]>)[{((){}){{}[]}}(<<>()>{{}()})]><<",
"[[[{[<({{<[[[<{}{}>(()())]{(<>[])([][])}]({{(){}}})]<[<{{}[]}{()}>[{<><>}]][<((){})([][])>]",
"[(<{<{(<<<<{{[[][]]<()[]>}){{<<>{}>}}>({[(()())(<>[])]}(<{()()}[<>]>{[[]]<<>()>}))>(<[{({}{})}][{[{}()]",
"<(<<[([[((<<{<[]{}>{{}<>}}(({}())[[]{}])>(<{<>()}[()()]>>>))]{<{{<(<()<>>{{}()})([{}<>](<><>))>",
"[{[<[([[<[((([()[]]<{}{}>))<{[{}()][(){}]}([{}<>]<()<>>)>)]>[{((([{}()]{()()>)<(<><>)(()[])>)[(([]()",
"{[{[{<<([({<<[{}()]<()<>>>{[[][]]({}())}>}[[<{{}<>}{<>}>]])(<<{[()[]]}(((){})({}{}))>[({{}()})]>)](",
"({{{<<<<(([([[<><>]<<>[]>]{<()<>><()[]>})<([<>{}])>])(<<{{()}<()[]>}<([]<>)>>{{[{}()][[]<>]}[{<>}{()()",
"[{(([{<{{(<{<<[]()>{{}<>}>}[<({}[])<{}<>>><{<>()}>]>)}<{{{{<<>{}>{()()}}}[[{()()}(()<>)><<{}<>>>]}[[(<(){}>(",
"[[{<[<(<[[<<({{}()}{{}})(({}{})[[]{}])>[([<>{}]({}<>))])]{<[<[[][]]<()<>>>]{([()()]{<><>})<{[]{}}[[]()]>}><",
"([<<{({[({[({<{}[]>{{}<>}}){<[<>[]]>[(()())]}]{{{{{}[]>{()<>}}}<[{{}<>}<[]()>]([<>]<<><>>)>}})",
"(([<[[{{(<[{{(()<>)}<<{}()>{<>{}}>}<[<[]()>[()()]]([<>()]{()})>)[(<[<><>]{{}<>}>{{{}()}{[]()}})<",
"[([[[([[[<[{{<()()>{[][]}}(<[][]>)}[{<{}()>{<>[]}}]]>({[[{<><>}<[][]>]([()]{()[]})]}{([<<><>>[{}(",
"(<({<[[[[(((({[]{}}<{}<>>)[<(){}>[()<>]])){<(<<>{}>)<<()<>><()[]>>>{[[()()]<[][]>][{{}()}<<>{",
"{{{{[[<{<{(<(([]())[{}[]])<(()<>){{}{}}}>){{{<{}[]><{}<>>}{(()[])[<><>]}}<{{()()}<<>[]>}>}}><(<[(<{",
"<<[(<<<([{<{(({}())[{}[]])(<(){}>(<><>))}>([[(<>[])(<>[])]<({}{})<{}>>](((<>())<{}[]>)[[<>",
"<{{((([[<{[(({<>{}}({}())))[([[]()][{}{}])]]}(([<([][])<<>()>>]<{{<>[]}(()())}[({}())[()()]]>)",
"(({[{[[[[(<<[[(){}][(){}]]<{()<>}<[][])>>{({[][]}{<>{}}){<[][]>}}><{(([]{}){{}<>}){[()<>][(",
"{<[[<<([<{<<{[<>{}}{<><>}}(({}()))>[[{[]()}](<<>>{<><>})]><<([<>{}]{[][]})[<{}[]>{<><>}]>>}{[{(<<>()><{}<>",
"({{{((({<<({<[<>()](()[])]}){((<{}()>{[]<>}){<[]{}>[[][]]})<[[[]{}](())](<{}<>>[{}])>}>[{{[(<>[])]}[<({}{",
"{<(<[{({[[[{[[{}<>][(){}]]{{(){}}}}<<[[]()]{<>}><[{}[]]>>]{<<((){})[{}]>({<><>}{()[]})><<[{}()]{",
"[[[(({<((<({<<{}>>}<[([]{})[[]]]>)<<{[()[]](<><>)}><<{[]{}}[[]]>{{()[]}{[]()}}>>><[((<(){}",
"{{<{{{<<{<{<((<>[])<()[]>)<(<>{}){[][]}>><(({}<>){[][]}){[()<>]{<>{}}}>}>[((<<(){})({}())><([]",
"[[[{({<[{[[<<(()<>)({}())>({<><>}[<><>])>]]<(<{<()<>>([]())}{[[]<>]{<>()}}>{<([][])((){})>([{}][()<>])})>}]<(",
"<<{[{[[<([[<<[{}<>]>[({}())<()[]>]>[{<(){}><{}<>>}[<<>>({}{})]]]<<{<()[]><()()>}({{}()}[{}<>])>>]<<([([](",
"{<<<(<{{[{{{<<{}[]>{()()}>{[<>[]]({}())}}}<[<([]())>{<()()>(()())}][<(()())<{}<>>>((<><>)[[][]]]]>",
"[[[({<(([[(<({()<>}<[]<>>)>[({[]}{<><>})<<(){}>{<><>}>])]]<(<[<<()()]<{}()>>(<{}()>([][]))]<<{<><>}>>>){",
"<<[[<({<({[<{(()[])}{{[]()}<[]{}>}>]<[(<[]{}><<>{}>)<[()[]]([]{})>]>})>((<([<[<><>]([]{}}><{<>()}<()[]>>]{",
"({[[[{{([[((<<{}<>}[{}<>]>)(({{}<>}<()()>)[[[]<>]<()<>>]))<(<{[][]}>)<{{[]<>}<[]<>>}[(<><>){(){}}]>>][<",
"{<[[[[[<[[{{{{()}[[][]]}[<(){}>[[][]]]}(<[{}{}]>)}(<<<()()>{<>}>>)]<([[[()<>]((){})]([[]()]<{}{}>)]([{{}(",
"[<(({(((<[(<<[[]{}][<><>]>[{(){}}[[]]]><{{()[]}<<>()>}{{()}{(){}}}>)(<[([]())]<{{}{}}(())>>)]([([{()[]}[[",
"(({[([{{((({{<<>[]>}}<([{}[]][[]()])[{{}[]}<<>{}>]>)<({([])<[]{}>}){(((){})[<>[]]){<<>[]>[{}()",
"<{<{(<<({([([([]())(<>[])][{()<>}{<>{}}])](({<()()>{()<>}}{{[]}[[][]]})[[[{}{}][()[]]]])]}(({[[{<>()}[{}()]",
"[[{[{{[({<{<(<{}<>>)[[{}{}>[<><>]]>[((())([]<>)){([]())<<><>>}]}>{{{<{<>[]}({}{})>{([]{}){[][]}}}[{{<>",
"[[{[<([{([<<<(<><>){[]{}}>{{[][]}([]<>)}>><{<<<>()>{<><>}>[<[][]>([]())]}({[{}[]]{<>()}}({()()}(()<>)))>])}])",
"{{<((([<[({{(([]){[][]})[(()<>)<()()>]}{{{()[]}}([()[]][{}{}])}})<{({[()[]]<[]{}>}[<()()><()[]>])",
"([<<<([{{<({{[{}<>][<>()]}{([]<>){(){}}}}){({<{}()>}[(()){<><>}])}><{<(<()[]>({}{}))(({}{})",
"{{[([<[{<<{<{[{}[]][(){}]}[[[]()]{()[]}]>}><[(([<>{}]){{<>()}{()<>}}){[{<>{}}[[]<>]]{<[]<>>}}][[[{[]<",
"{<<<<{(((<{([{{}{}}][[[]()]<<>()>])<([()<>]([]))[[<><>][{}()]]>}{<{{(){}}<()<>>}<{<>{}}{<>()}>>(<{",
"<[({<{{{<((<<({})([]<>)>((<>[]){[]()}}>)(<[<(){}>({}[])]>[<({}<>){[][]}>[{()<>}<<><>>]]))>[({[([<>{}][{}()])<",
"(({[[{<{[[((<[<>()]><{()<>}[[]<>]>)([{[]()}[[]()]](({}{}){<>()})>){<{(()())(<>[])}[<()[]>[()()]",
"[(([{{<{<[{{{[{}{}]<(){}>}[<[]{}>({}())]}({[()[]]{[]()}}[<{}[]>(<>)])}[{{<[]{}>(()<>)}<[[]()]<<>[]>)}<<<<>()",
"<(<<{<([([(<[{{}<>}<()()>][{()[]}(<><>)]>{{<[]<>><{}[]>>{{{}}{[]<>}}})({[<[]{}>[[][]]]}{{<",
"((<<<([[<<{([<<>{}>{<>()}])<<{[]{}}[()[]]>>}[<{([]())[<>{}]}>{((()[]){{}<>))[<()<>>([]<>)]}]>{(({[[]]",
"{<<((({({[<[[[<><>][<>{}]]{({}<>)<()[]>}][<<[]{}}<[]()>>[[[]<>]]]>([[[{}{}]]<<<><>><<>{}>>",
"[{<([{{<{(<{{{(){}}{{}[]}}(<<>()>[()[]])}{{{{}}(()())}{[()<>]}}>[{[{[][]}{{}<>)]}((((){}){[]{}})(({})<<>{}",
"[{[(<[{<{{[<{{()()}{()[]}}<<()()><{}[]>>>][<({()()}[()[]]){([][])[<>{}]}>(((()()))((<>{})<{}{",
"(<(<([<<<{[<({<>}{()()})><((<>))<<{}[]><<><>>>>]{<{[[][]]}{{[]{}}{[]<>}>>[[[[]()]({})]]}}><<<<",
"<([<(<<<(({{<[<><>]<[]<>>>(<[]()>[{}<>])}[<(()()){{}<>}>]}))<<[{{[<>[]]<()[]>}{(()<>){()()",
"<[(<{{[[[<(([[<>()]([][])])){{{[()()]{{}[]}}[([]{}){(){}}]}{[<[]>{[]()}][[<>]({}())]}}>]]<(<[{<{<>()}{()[",
"<{{{[(<{<[<{{<()>(<>{})}[({}()){()()}]]([{<>{}}[()()]](<[]<>><<>{}>))>[<{<[]()>(<>)}<{[]{}}[(",
"<{(<[<[<{<({<[<><>}[[]()]>}([<(){}><<><>>][<()()><<><>>]))([[([]())<{}>]<[()()]{<>{}}>]{(({}",
"<(<({(<[<[(((<<>{}>{{}()})){{[[]()](())}{{<><>}<<><>>}})([<<()()><[]())>[[<>()]<<>[]>]][<{()()}",
"((<[{{(<[([<([()()](<>{}))(<{}()>[{}{}])>({<{}{}>(<>[])})])]>)}<({((([(<[]{}>({}[]))]{((<><>)(()()))}))(({{<{",
"{({[<<[(<<((<<{}[]>[()<>]>{<<>[]>{[]()}}){[<<><>>[()[]]]<<{}()>[()<>]>})[{[{{}<>}{()}]}<(<()[]><{}{}>)[[",
"{{[<((<((<{[([[][]]<{}<>>)((()[]))]}>{[{(({}())[()[]]){{[][]}([][])}}](<<[<><>]{<>}><<{}<>><[][]>>>",
"[[[<(<{{([{(<(<>{})(()<>)><(<>[])[{}()]>)([[[]()][[]<>]])}[[{<[]()>(<><>)}[(()){<>()}]]({{[]()}})]])[[",
"<({([{(<{{[<<[(){}][[]()>>[[{}{}](()[])]>]{{[[{}<>]{{}<>}]{({}<>)[{}{}]}}[({()()}[{}<>]){((){})}]}}{{[[{{",
"[[[[{<[<(([<[<[]{}><<>{}>]<<[]<>>(()[])>>([(<>)<{}()>])])<{{({[]{}}{[]()})}<[[<><>]{[]<>}]{<<>()><<>()>}>",
"<<<[([[(({(<[<{}>[{}()]]{{()}(()[]}}>(<<<>()>(<>[])>))<<[{<>()}{<>[]}][{[]{}}<{}[]>]>>}){<<<(<<>",
"{{<[{{({{(([[([]{})<{}()>]]))){(<{{<<>[]>(<>[])}<<()><[]<>>>}>([([<>()]<{}[]>)(({}{}))]<<([]())[<>",
"([<[({[{{[[[({<>{}}<(){}>)({<>[]}{()<>})](([(){}]{[]()}))]<[<(<>[])({}<>)>][[[[]{}]<()>]<<<>[]>{[]<>}>]>]",
"{[{[[{<(<<({{([]<>)([]{})}<<{}<>><<>[]>>}(({()()}[{}()]){(<><>)[<>[]]]))<<[([])(<>[])]{([]())(",
"({<<{{[<<[{{<[(){}][[]]><{[]()}<[]{}>>}[<<<>()>{{}()}>[<{}<>>[<><>]]]}](<<[(<>{})[()]}{<<>><[]",
"<<<([{[([{{[{[[]<>][<>[]]}]}{<([[][]]){[<>[]]<{}()>}><(<[]<>>(<>{}))[<[][]>{<>}]>}}{<{{[<>{}]{()",
"<((<([([<{<[([{}<>](<>()))<([]<>)([]<>)>][<{()<>}{[]<>}>]>}<{[(<[]()>(<><>))[<(){}>[[][]]]](<([]())<<>[]>>[",
"{[<[<<{{(<{[{((){})<{}[]>}[([][])]]}{[({()<>}){[{}<>](<>{}))]}>)}<[[(<(<()<>>){(()())([]{})}>({[{}[]]",
"<([[<({{[<({[({}{}){{}()}]<((){})[<><>]>})([[{[][]}<()<>>]<[()<>][{}{}]>])>]}}){{[(({(({[]()}{()()}",
"<({([<[{(<[{(({}[]))}[[{[]<>}{{}[]}](({}[]))]]<[[(()[])[()()]]{[{}()>}]>>{<<{[[]<>](()())}[<{}[]>(<>",
"(([[<(<<[{<(<[{}{}]{()<>}>)((<(){}>([]))({<>{}}[<>[]]))>(<<{()[]}{(){}}>[[<>()]]>[<{()[]}<()[]>>{({}<>){[]<",
"{<[<<{(<{{<[{[{}()][<><>]}][{({}{})(<>[]))]>{<[[<><>]]<<<>()>({}[])>>({<[]<>>([]<>)}{[(){}]([]{})})",
"{{<((([<{(([{[<>{}]{{}<>}}])<<<{<>[]}{(){}}>{(()[])[()[]]}>{{<<>()>}([(){}]{{}<>})}>)}{(([{{{}[]}(<>())",
"{[(<{{{<[[{{[[()[]](<>{})]((()<>)({}[]))}}]][{([[{{}[]}<[]<>>]][{(<>{})}[(<>()){<><>}]])}>>[([",
"<<<{([((<<{(({{}{}}({}{})))}{(<(<><>)[[]<>]>{[{}[]](<>)})<{{<>()}{{}<>}}<<<>[]><<>()>>>}>>))]){",
"<{(<[[(({<[{{<<><>><{}<>>}<<<>{}>{()()}>}]>}))[((([([{[]{}}]([{}()][<><>]))(((<>())(<>]))][",
"([<<[({(({{((<[]{}>{()[]}})({[<><>][<>()]}(<<><>>[[]()]))}{{{(()<>)({}{})}(<{}()><[]()>)}{{{<><>}",
"[<<<{{<<{<{<<[()()](<><>)>>([({}){{}[]}]{<[]()>{{}()}})}<[{([]())<{}<>>}([{}()]<{}[]>)]<(<[]",
"{{<[({({<{({((()<>)){[[]()]<(){}>>}<[[{}]{<><>}]<(()<>)<()()>>>)}(({((<><>)[{}[]]){[[]()][()[]]}})<({",
"<[{<({<({(({{<(){}>[[]{}]}<<[][]><{}{}>>})[(([{}()][<>()]))[(<<>{}>([][]}){[[]{}]}]])[<[{(()<>)[{}<>]}]>]",
"([(([{<(<{[<{([][]){[][]}}(<<>><[]{}>)>({[<>()]{{}<>}}(<<>[]>{<>{}}))][({{[]()}{[]}}(([]{})(()<>))",
"<{<<<({[[(<<{(()<>)[[]{}]}<<()()>>>><[({()[]}[[][]]){<[][]>(<><>)}][(({}{})<()[]>){{{}()}<[]{}>}]>)[<((([]{}",
"<([[([<<<{<<<<<><>>({}())>{{[]()}[{}[]]>>[<[<>()]({}{})>]>(({<{}{}>{<>{}}}{<{}[]>{{}()}}){[<[]()>{()<>}",
"[{{<{[{{{<{{<([][])[()<>]>{{[]{}}({}())}}((<<>[]>([][])))}><{<<<{}<>><<>()>>{(()<>){[]{}}}>}{([{[][]}{<>{}}])",
"[({<((({(<{[{<[][]}(<>[])}<<{}<>>{{}<>}>]({{<>()}[{}{}]})}(<{{{}()}<<>[]>}[([]{})<[][]>]>[{(<>",
"<([[[<{{<<<[(((){})(()()))([<><>]{()})]<<[<>]([])>(([]<>))>>{{[<()>]<(()[])([][])>}[({{}}<{}{",
"{<<((<[{<{<[{[[][]]{<><>}}{<(){}>{<><>}}]<((<>{})<<>[]>)>>((((<>[]){[]()})({<>()}))([[{}[]]{<>[]}]<",
"(<{(<[[([[([<({}{})[()<>]>])][<{<({}())><{()()}>}>{[{[{}<>]([])}](([()()]))}]])]]>)}>[[({{",
"(<[[[{<{[<([{({}{}){{}()}}[(<>{})<()()>]][{{{}()}}<{<>[]}[()<>]>]){{((<><>){()<>])<<<>()>[{}[",
"<{<<[((<<<{([{{}<>}({})]{((){})[[]<>]})<[[()<>]([]())](<[]<>>({}<>))>}{(<{()[]}>{<[]<>>})<",
"{[([<[<[({{[<[<>()][{}[]}>((<>())<[]<>>)]{(<{}<>>(()()))([()()])}}}<(<(<<>{}>{<>{}})><({[]{}}[",
"{{[[[<<<<[[{({[]<>}<()()>)<<(){}>{<><>}>}{[([]<>)[<>[]]]}]{<[{()()}(<><>)]{{<>{}}<[]{}>}>((<{}()>{(){}}))}>>>",
"({[<[[<{<([<<<()<>}<{}{}>>(<<>[]>(<>()))><{[<>()]({}<>)}<{[]{}}>>])>}{{{<{({[]{}}<<>>)<<[]<>",
"([((((<(<[({((<>())<()<>>)}([<{}()>{<>()}]{{{}()}{[]<>)}))([<(<>{})><[(){}][<>()]>](([()]<[]{}>)(<{}{}>{()",
"{[(<{({(<([(<[{}()][{}()]>)[[[{}()](()())]<{[][]}<[]<>>>]][({[()()]{{}{}}}((<><>)(<>())))<<{()()}{[]{}}}[{[]",
"<([[{<<{<<{(([()<>]{<>[]})<<[][]>({}[])>)({<{}{}>([]<>)})}{<{{[][]}{[]{}}}[((){})((){})]><([[][]]){{()()}}>}",
"(([<[[[(({{[[[[][]](<>())]{<<>><<>()>}]<<(()<>)>[<<>{}>{<><>}]>}[<(<<><>><{}{}>)[<()<>><[]()>]>[{<()[]>[<",
"{[{{{[(<<[<[{[()()]<{}<>>}[([]<>)({}<>)]][<{()()}[<>[]]>]>]>>)]{([({[{({<>}(<>{}))[({}())[[][]]]}<{{()[]",
"(<(<{<{<[[(({[<>[]]<{}[]>}[([]{})(()[])]))({([[]])([()()]{()[]})}<[<<><>><[]<>>]>)]]<([{{{{}<>}(<>)}}<({",
"[<[{[<<[<<[<{<<>[]}<()>}{(()[])[{}[]]}><[<(){}>{{}[]}]>]>(((<{{}<>}{()[]}><<<>{}>{()[]}>)[[(",
"[<{(<[<{{([{{<<>{}><[]()>}({(){}}[[]{}])}{[<[][]>[<><>]][<<><>>[{}{}]]}](<<{(){}}({}<>)>(<()[]>[()[]])>",
"<[{<({((([(<([[]<>]<()[]>)<(<>())>>(<{[][]>(<>{})>[{(){}}]))])))}<<{({<<<([]{})([]())>[{()()}<()<>>]",
"<[(<{((({<<{{[{}<>]}[[<>{}]({}[])]}{(<{}[]}{<>})<{[]()}[()[]]>}>>}))(<<[<<(<<>{}><<>{}>)<<"
                };
        }
    }
}
